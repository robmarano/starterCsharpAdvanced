using System.IO;
using System.Net;
using System.Net.Sockets;
using System;
using System.Threading;
using System.Collections;


namespace ChatServer
{
    class ChatServer
    {
        TcpListener chatServer;
        public static Hashtable nickName;
        public static Hashtable nickNameByConnect;

        public ChatServer()
        {
            //create our nickname and nickname by connection variables
            nickName = new Hashtable(100);
            nickNameByConnect = new Hashtable(100);
            //create our TCPListener object
            Int32 port = 4296;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");
            chatServer = new TcpListener(localAddr, port);
            //check to see if the server is running
            //while (true) do the commands
            while (true)
            {
                //start the chat server
                chatServer.Start();
                //check if there are any pending connection requests
                if (chatServer.Pending())
                {
                    //if there are pending requests create a new connection
                    TcpClient chatConnection = chatServer.AcceptTcpClient();
                    //display a message letting the user know they're connected
                    Console.WriteLine("You are now connected");
                    //create a new DoCommunicate Object
                    DoCommunicate comm = new DoCommunicate(chatConnection);
                }
            }
        }
        public static void SendMsgToAll(string nick, string msg)
        {
            //create a StreamWriter Object
            StreamWriter writer;
            ArrayList ToRemove = new ArrayList(0);
            //create a new TCPClient Array
            TcpClient[] tcpClient = new TcpClient[ChatServer.nickName.Count];
            //copy the users nickname to the CHatServer values
            ChatServer.nickName.Values.CopyTo(tcpClient, 0);
            //loop through and write any messages to the window
            for (int cnt = 0; cnt < tcpClient.Length; cnt++)
            {
                try
                {
                    //check if the message is empty, of the particular
                    //index of out array is null, if it is then continue
                    if (msg.Trim() == "" || tcpClient[cnt] == null)
                        continue;
                    //Use the GetStream method to get the current memory
                    //stream for this index of our TCPClient array
                    writer = new StreamWriter(tcpClient[cnt].GetStream());
                    //white our message to the window
                    writer.WriteLine(nick + ": " + msg);
                    //make sure all bytes are written
                    writer.Flush();
                    //dispose of the writer object until needed again
                    writer = null;
                }
                //here we catch an exception that happens
                //when the user leaves the chatroow
                catch (Exception ex)
                {
                    string str = (string)ChatServer.nickNameByConnect[tcpClient[cnt]];
                    //send the message that the user has left
                    ChatServer.SendSystemMessage("** " + str + " ** Has Left The Room.");
                    //remove the nickname from the list
                    ChatServer.nickName.Remove(str);
                    //remove that index of the array, thus freeing it up
                    //for another user
                    ChatServer.nickNameByConnect.Remove(tcpClient[cnt]);
                }
            }
        }
        public static void SendSystemMessage(string msg)
        {
            //create our StreamWriter object
            StreamWriter writer;
            ArrayList ToRemove = new ArrayList(0);
            //create our TcpClient array
            TcpClient[] tcpClient = new TcpClient[ChatServer.nickName.Count];
            //copy the nickname value to the chat servers list
            ChatServer.nickName.Values.CopyTo(tcpClient, 0);
            //loop through and write any messages to the window
            for (int i = 0; i < tcpClient.Length; i++)
            {
                try
                {
                    //check if the message is empty, of the particular
                    //index of out array is null, if it is then continue
                    if (msg.Trim() == "" || tcpClient[i] == null)
                        continue;
                    //Use the GetStream method to get the current memory
                    //stream for this index of our TCPClient array
                    writer = new StreamWriter(tcpClient[i].GetStream());
                    //send our message
                    writer.WriteLine(msg);
                    //make sure the buffer is empty
                    writer.Flush();
                    //dispose of our writer
                    writer = null;
                }
                catch (Exception ex)
                {
                    ChatServer.nickName.Remove(ChatServer.nickNameByConnect[tcpClient[i]]);
                    ChatServer.nickNameByConnect.Remove(tcpClient[i]);
                }
            }
        }


    }
}
