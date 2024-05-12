using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    internal class Client
    {
        TcpClient tcpClient;
        StreamReader streamReader;
        StreamWriter streamWriter;
        Guid Id;

        public event Action<Client, string> MsgReceived;

        public Client(TcpClient tcpClient)
        {
            this.tcpClient = tcpClient;
            Id = Guid.NewGuid(); 

            NetworkStream stream = tcpClient.GetStream();

            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
            streamWriter.AutoFlush = true;

            RecieveMessages();

        }

        private async void RecieveMessages()                   // async func >> will not block other code
        {
            while (true)
            {
                string msg = await streamReader.ReadLineAsync();  // using await here >> upcoming lines will not be executed till readlineasync executed, >> till that happened control returned to calling thread to continue with other tasks >> which are code after calling this func

                if(MsgReceived != null) 
                { 
                    MsgReceived(this, msg);
                }
            }
        } 

/**/        public async Task Send(string message)     // why err with void >> prev func no err?????
        {
            await streamWriter.WriteLineAsync(message);
        }
    }
}

// async - await >> no new thread is created >> work synchronously in same thread >> when see async await >> mean return control to calling thread to continue executing other code and when this async func returned some thing >> control will be returned to it to continue lines after async - await line >> mostly with i-o operations >> no need for new task in cpu
// on the other hand >> if cpu operation and also independent task >> u can make new thread here

// tcp "network prog.." >> low level programming "can be used for various usages over than signalr which is high level programming" >> handle connections manually >> better performance >> used in one to one communication , signal r >> high level of abstraction >> automatic handling less performance but better readbility and maintainablility >> used in broadcasting to many apps >> real time web apps...

// try send participant obj for all connectors with server !!!!!!