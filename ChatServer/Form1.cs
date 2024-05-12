using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        List<Client> clients = new List<Client>();
     
        public Form1()
        {
            InitializeComponent();
            //clientsListBox.Items.Add("dssa");
            //clientsListBox.Items.Add("www");
          
        }

        private async void Start()
        {
            IPAddress ipAddress = IPAddress.Parse("192.168.1.4");

            TcpListener tcpListener = new TcpListener(ipAddress, 5500);
            tcpListener.Start();

            while (true) 
            { 
/**/                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();  // same obj accept many connections in same time or will work sequential????
                Client client = new Client(tcpClient);
                client.MsgReceived += Client_MsgReceived;

                clients.Add(client);
           
                updateListBox();

            }
        }

        private void updateListBox()
        {
            clientsListBox.DataSource = null;
/**/            clientsListBox.DisplayMember = "Id";    // no work???????
            clientsListBox.ValueMember = "Id";   
            clientsListBox.DataSource = clients;
        }

        private void Client_MsgReceived(Client client, string message)
        {
            txtReceivedMessages.Text += Environment.NewLine;
            txtReceivedMessages.Text += message;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            //foreach (Client client in clients)
            //{
            //    await client.Send(txtMsg.Text);
            //}
            List<Client> selectedClients = new List<Client>();
            foreach(Client client in clientsListBox.SelectedItems)
            {
                client?.Send(txtMsg.Text); 
            }

           // Client client = (Client) clientsListBox.SelectedItems;
           // client?.Send(txtMsg.Text);
        }



        private async void sendAllBtn_Click_1(object sender, EventArgs e)
        {
            foreach (Client client in clients)
            {
                await client.Send(txtMsg.Text);
            }
        }
    }
}
