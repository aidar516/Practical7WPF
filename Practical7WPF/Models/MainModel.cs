using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Practical7WPF.ViewModels;

namespace Practical7WPF.Models
{
    public class MainModel
    {
        public MainModel(string Ip, string Login)
        {
            this.Login = Login;
            this.Ip = Ip;
        }
        public string Ip { get; set; }
        public string Login { get; set; }
    }

    public static class TcpServer
    {
        private static Socket socket;
        private static List<Socket> clients = new List<Socket>();

        public static void ServerStart()
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ipPoint);
            socket.Listen(2);
            ListenToClient();
        }
        private static async Task ListenToClient()
        {
            while (true)
            {
                Socket client = await socket.AcceptAsync();
                clients.Add(client);
                RecieveMessage(client);
            }
        }
        private static async Task RecieveMessage(Socket client)
        {
            while (true)
            {
                byte[] bytes = new byte[1024];
                await client.ReceiveAsync(bytes, SocketFlags.None);
                string message = Encoding.UTF8.GetString(bytes);

                foreach (Socket item in clients)
                {
                    SendMessage(item, message);
                }
            }
        }
        private static async Task SendMessage(Socket client, string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            await client.SendAsync(bytes, SocketFlags.None);
        }
    }
    public static class TcpClient
    {
        private static Socket socket;
        private static string name = "Admin";
        private static HashSet<string> names = new HashSet<string>();

        public static void ClientStart()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 8888);
            RecieveMessage();
        }

        private static async Task RecieveMessage()
        {
            while (true)
            {
                byte[] bytes = new byte[1024];
                await socket.ReceiveAsync(bytes, SocketFlags.None);
                string message = Encoding.UTF8.GetString(bytes);

                if (message.Split(": ")[2] == "/disconnect")
                    names.Remove(message.Split(": ")[1]);
                else
                {
                    names.Add(message.Split(": ")[1]);
                    FirstViewModel.Message.Add(message);
                    SecondViewModel.Message.Add(message);
                }
                FirstViewModel.Users.Clear();
                SecondViewModel.Users.Clear();
                foreach (string name in names)
                {
                    FirstViewModel.Users.Add(name);
                    SecondViewModel.Users.Add(name);
                }

            }
        }

        public static async Task SendMessage(string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(MessageFormat(message));
            await socket.SendAsync(bytes, SocketFlags.None);
        }

        private static string MessageFormat(string message)
        {
            return DateTime.Now + ": " + name + ": " + message;
        }

    }
}
