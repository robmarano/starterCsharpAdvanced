using System.IO;
using System.Net;
using System.Net.Sockets;
using System;
using System.Threading;
using System.Collections;

namespace starterCsharpAdvanced
{
    class ChatClient
    {
        static TcpClient tcpClient;

        public ChatClient()
        {
            tcpClient = new TcpClient();
            tcpClient.Connect("127.0.0.1", 4296);
            Thread chatThread = new Thread(new ThreadStart(run));
            chatThread.Start();
        }

        private static void run()
        {
        }
    }
}
