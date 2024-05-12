using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        StreamReader streamReader;
        StreamWriter streamWriter;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Connect()
        {
            TcpClient tcpClient = new TcpClient();
            await tcpClient.ConnectAsync("192.168.1.4", 5500);

            NetworkStream stream = tcpClient.GetStream();
            
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            streamWriter.AutoFlush = true;

            while (true)
            {
                string msg = await streamReader.ReadLineAsync();
                txtReceivedMessages.Text += Environment.NewLine;
                txtReceivedMessages.Text += msg;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            streamWriter.WriteLine(txtMsg.Text);
        }
    }
}
