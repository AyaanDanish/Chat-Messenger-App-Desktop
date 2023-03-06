using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace CN_Assignment_1___Client
{
    public partial class ClientWindow : Form
    {
        private static Socket serverSocket;
        public delegate void labelDelegate(Color labelColor, string labelText);
        public delegate void listboxDelegate(string message, bool fromMe);

        public ClientWindow()
        {
            InitializeComponent();
        }

        //Runs at every keypress in the port text box, used to only allow digits 
        private void IPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        //Sets cursor to the IP window as soon as the window opens
        private void ClientWindow_Shown(object sender, EventArgs e)
        {
            IPTextBox.Focus();
        }

        //Function that changes the color of the ConnectionStatus label (can be called as a delegate too
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
                MessageListBox.Items.Add("Server: " + message);
            }
        }

        //Background thread function that listens for messages and receives them
        //Any UI changes that are done within background threads need to be done through a delegate
        //Delegates forward the UI change call to the main thread and executes it there
        public void ReceiveMessages()
        {
            while (true)
            {
                try
                {
                    //Receive the message in a buffer and resize the buffer to fit the message
                    byte[] recvBuffer = new byte[serverSocket.SendBufferSize];
                    int bytesReceived = serverSocket.Receive(recvBuffer);
                    if (bytesReceived == 0) 
                    {
                        DisconnectFromServer();
                        break;
                    }
                    Array.Resize(ref recvBuffer, bytesReceived);

                    //Convert the raw bytes into encoded string and add it to listbox using delegate
                    string recvMessage = Encoding.ASCII.GetString(recvBuffer);
                    MessageListBox.BeginInvoke(new listboxDelegate(AddToListBox), recvMessage, false);
                }
                catch
                {
                    //If any disconnection occurs, set the status to disconnected and close the socket
                    DisconnectFromServer();
                    break;
                }
            }
        }

        //Runs when the connect button is clicked
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            int port; 
            string[] address = IPTextBox.Text.Split(':');
            string ip = address[0];
            int.TryParse(address[1], out port);

            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

            try
            {
                //Try to connect to the host and set the status to connected if it succeeds
                serverSocket.Connect(localEndPoint);
                ChangeStatus(Color.DarkGreen, "Connected");

                //Creates a new thread to accept an incoming connection, since it is a blocking call we do it in a separate thread
                Thread thread = new Thread(ReceiveMessages);
                thread.IsBackground = true; //Ensures that the thread doesn't keep the program running
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Unable to connect to host!");
                return;
            }
        }

        //Function that runs when the send button is clicked - Sends the items of the textbox to the server
        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (OutgoingTextBox.Text.Length == 0) return;
            if (serverSocket == null) return;

            byte[] sendData = Encoding.ASCII.GetBytes(OutgoingTextBox.Text);
            serverSocket.Send(sendData);
            AddToListBox(OutgoingTextBox.Text, true);
            OutgoingTextBox.Clear();
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            DisconnectFromServer();
        }

        private void DisconnectFromServer()
        {
            if (serverSocket == null) return;

            serverSocket.Close();

            ConnectionStatusLabel.BeginInvoke(new labelDelegate(ChangeStatus), Color.Red, "Disconnected");
        }
    }
}
