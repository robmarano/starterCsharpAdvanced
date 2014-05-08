using System.IO;
using System.Net;
using System.Net.Sockets;
using System;
using System.Threading;
using System.Collections;

namespace ChatClient
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
            Thread readThread = new Thread(new ThreadStart(readingRun));
            Thread writeThread = new Thread(new ThreadStart(writingRun));
        }

        private static void readingRun()
        {

        }

        private static void writingRun()
        {

        }
    }
}
