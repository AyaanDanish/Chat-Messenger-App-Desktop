using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace CN_Assignment_1
{
    public partial class ServerWindow : Form
    {
        private static Socket listenerSocket; //Socket used to listen for and establish new connections
        private static List<Socket> clientSocketList = new List<Socket>(); // List of all currently connected client sockets
        private static Dictionary<Socket, string> clientNames = new Dictionary<Socket, string>(); // Stores the name of each client
        private static byte[] buff = new byte[1024]; //Global buffer of fixed size

        public delegate void labelDelegate(Color labelColor, string labelText); //Delegate used to forward label changing operations to the main thread
        public delegate void listboxDelegate(string message, bool fromMe, Socket currentSocket); //Delegate used to forward listbox updating operations to main thread
         
        public ServerWindow()
        {
            InitializeComponent();
        }
         
        //Runs at every keypress in the port text box, used to only allow digits 
        private void PortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Sets cursor to the IP window as soon as the window opens
        private void ServerWindow_Shown(object sender, EventArgs e)
        {
            PortTextBox.Focus();
        }

        //Function that changes the color of the ConnectionStatus label (can be called as a delegate too)
        public void ChangeStatus(Color labelColor, string labelText)
        {
            ConnectionStatusLabel.BackColor = labelColor;
            ConnectionStatusLabel.Text = labelText;
        }

        //Function that adds a message to the listbox alongside who wrote the message (can be called as a delegate too)
       public void AddToListBox(string message, bool fromMe, Socket currentSocket)
        {
            if (fromMe)
            {
                MessageListBox.Items.Add("Me: " + message);
            }
            else
            {
                //Output the message alongside the name of the client who sent it
                MessageListBox.Items.Add(clientNames[currentSocket] + ": " + message);
            }
        }

        
        //Runs when the listen button is clicked
        private void ListenBtn_Click(object sender, EventArgs e)
        {
            //Extracts the port number from the text box and stores it in 'port'
            int port;
            Int32.TryParse(PortTextBox.Text, out port);

            //Create new server socket to listen for incoming connections
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //Binds this socket to the port that was entered, and listens for connections (blocking call)
            try
            {
                listenerSocket.Bind(new IPEndPoint(IPAddress.Any, port));
                listenerSocket.Listen(5);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("This port is already in use, please enter another.");
                return;
            }

            //Set status to awaiting connection
            ChangeStatus(Color.Yellow, "Awaiting Connection");

            //Spin off a new thread to that runs the AcceptConnections() function to accept new incoming connections
            listenerSocket.BeginAccept(new AsyncCallback(AcceptConnection), null);
        }

        public void AcceptConnection(IAsyncResult AR)
        {
            Socket newSocket;
            //Accept the new incoming connection in a new socket and add it to the client socket list, and add the client name to the dictionary
            try 
            {
                newSocket = listenerSocket.EndAccept(AR);
            } 
            catch 
            {
                return;
            }
            clientSocketList.Add(newSocket);
            clientNames.Add(newSocket, "Client " + clientSocketList.Count.ToString());

            //Set status to connected and update number of clients using delegate 
            ConnectionStatusLabel.BeginInvoke(new labelDelegate(ChangeStatus), Color.DarkGreen, "Connected (" + clientSocketList.Count + ")");

            //Receive this client's message into the global buffer (calls the ReceiveMessages() callback function in a new thread)
            try
            {
                newSocket.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(ReceiveMessages), newSocket);
            }
            catch
            {
                DisconnectClient(newSocket);
            }


            //Continue listening for more client connections by calling itself again (because EndAccept() stops listening)
            listenerSocket.BeginAccept(new AsyncCallback(AcceptConnection), null);
        }

        //Any UI changes that are done within background threads need to be done through a delegate
        //Delegates forward the UI change call to the main thread and executes it there
        public void ReceiveMessages(IAsyncResult AR)
        {
            //Get the newly created socket sent over by the BeginReceive() call
            Socket currentSocket = (Socket)AR.AsyncState;
            int bytesReceived = 0;
            
            //Receive the message through this socket into the global buffer (of fixed size) and copy it to the local buffer (of exact size)
            try
            {
                bytesReceived = currentSocket.EndReceive(AR);
                if(bytesReceived == 0)
                {
                    DisconnectClient(currentSocket);
                    return;
                }
            }
            catch
            {
                DisconnectClient(currentSocket);
                return;
            }


            byte[] recvBuffer = new byte[bytesReceived];
            Array.Copy(buff, recvBuffer, bytesReceived);

            //Decode the message into a string
            string recvMessage = Encoding.ASCII.GetString(recvBuffer);

            //Write the received message to the list box
            MessageListBox.BeginInvoke(new listboxDelegate(AddToListBox), recvMessage, false, currentSocket);
            
            //Receive the next message (by calling itself)
            currentSocket.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(ReceiveMessages), currentSocket);
        }

        //Function that runs when the send button is clicked - Sends the items of the textbox to the client
        private void SendBtn_Click(object sender, EventArgs e)
        {
            //Handle exceptions for empty textbox and no connections
            if(OutgoingTextBox.Text.Length == 0) return;
            if (clientSocketList.Count == 0) return;
            
            //Encode the textbox text into bytes
            byte[] sendData = Encoding.ASCII.GetBytes(OutgoingTextBox.Text);
            
            //Send the message to all clients
            foreach(Socket client in clientSocketList)
                client.Send(sendData);
            
            //Write the message to the List Box
            AddToListBox(OutgoingTextBox.Text, true, null);
            OutgoingTextBox.Clear();
        }

        //Runs when disconnect button is clicked, disconnects the connection
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            DisconnectClient();
        }

        //Function that disconnects a certain client from the server, and adjusts the connection status accordingly
        private void DisconnectClient(Socket socketToDisconnect)
        {
            //listenerSocket.Close();
            if (clientSocketList.Count == 0) return;

            foreach (Socket client in clientSocketList)
            {
                if (client == socketToDisconnect)
                {
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                    client.Dispose();
                }
            }

            clientSocketList.Remove(socketToDisconnect);
            if (clientSocketList.Count == 0)
                ConnectionStatusLabel.BeginInvoke(new labelDelegate(ChangeStatus), Color.Red, "Disconnected");
            else
                ConnectionStatusLabel.BeginInvoke(new labelDelegate(ChangeStatus), Color.DarkGreen, "Connected (" + clientSocketList.Count + ")");

        }

        //Override of the previous function that disconnects ALL clients from the server, and sets the status to Disconnected
        private void DisconnectClient()
        {
            listenerSocket.Close();
            if (clientSocketList.Count == 0) return;

            foreach (Socket client in clientSocketList)
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();
                client.Dispose();
            }

            clientSocketList.Clear();
            ConnectionStatusLabel.BeginInvoke(new labelDelegate(ChangeStatus), Color.Red, "Disconnected");



        }

    }
}
