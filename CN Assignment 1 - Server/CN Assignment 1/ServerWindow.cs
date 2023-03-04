using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace CN_Assignment_1
{
    public partial class ServerWindow : Form
    {
        private static Socket listenerSocket;
        private static Socket clientSocket;
        public delegate void labelDelegate(Color labelColor, string labelText);
        public delegate void listboxDelegate(string message, bool fromMe);

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
       public void AddToListBox(string message, bool fromMe)
        {
            if (fromMe)
            {
                MessageListBox.Items.Add("Me: " + message);
            }
            else
            {
                MessageListBox.Items.Add("User: " + message);
            }
        }

        //Background thread function that listens for messages and receives them
        //Any UI changes that are done within background threads need to be done through a delegate
        //Delegates forward the UI change call to the main thread and executes it there
        public void ReceiveMessages()
        {
            //Accept an incoming connection
            clientSocket = listenerSocket.Accept();

            //Set status to connected using delegate
            ConnectionStatusLabel.BeginInvoke(new labelDelegate(ChangeStatus), Color.DarkGreen, "Connected");

            //Listener socket is no longer needed so we can close it now
            listenerSocket.Close();

            while (true)
            {
                try
                {
                    //Receive the message in a buffer and resize the buffer to fit the message
                    byte[] recvBuffer = new byte[clientSocket.SendBufferSize];
                    int bytesReceived = clientSocket.Receive(recvBuffer);
                    Array.Resize(ref recvBuffer, bytesReceived);

                    //Convert the raw bytes into encoded string and add it to listbox using delegate
                    string recvMessage = Encoding.ASCII.GetString(recvBuffer);
                    MessageListBox.BeginInvoke(new listboxDelegate(AddToListBox), recvMessage, false);
                }
                catch
                {
                    //If any disconnection occurs, set the status to disconnected and close the socket
                    ConnectionStatusLabel.BeginInvoke(new labelDelegate(ChangeStatus), Color.Red, "Disconnected");
                    clientSocket.Close();
                    break;
                }
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
                listenerSocket.Listen(0);
            } 
            catch 
            {
                MessageBox.Show("This port is already in use, please enter another.");
                return;
            }

            //Set status to awaiting connection
            ChangeStatus(Color.Yellow, "Awaiting Connection");
            //Creates a new thread to accept an incoming connection and receive messages
            Thread thread = new Thread(ReceiveMessages);
            thread.IsBackground = true; //Ensures that the thread doesn't keep the program running
            thread.Start();
        }

        //Function that runs when the send button is clicked - Sends the items of the textbox to the client
        private void SendBtn_Click(object sender, EventArgs e)
        {
            if(OutgoingTextBox.Text.Length == 0) return;
            if(clientSocket == null) return;

            byte[] sendData = Encoding.ASCII.GetBytes(OutgoingTextBox.Text);
            clientSocket.Send(sendData);
            AddToListBox(OutgoingTextBox.Text, true);
            OutgoingTextBox.Clear();
        }

        //Runs when disconnect button is clicked, disconnects the connection
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            if (clientSocket == null) return; 

            clientSocket.Close();
            ChangeStatus(Color.Red, "Disconnected");
        }

    }
}
