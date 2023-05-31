using Practical7WPF.Models;
using Practical7WPF.Views;
using Practical7WPF.Views.Helpers;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Windows;

namespace Practical7WPF.ViewModels
{
    internal class MainViewModel : BindingHelper
    {
        public MainModel Enter { get; set; } = new MainModel("127.0.0.1:8888", "login");
        public DelegateCommand Create
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (Validation.EnterValidate(Enter))
                    {
                        TcpServer.ServerStart();
                        TcpClient.ClientStart();
                        Server server= new Server();
                        TcpClient.SendMessage("Пользователь " + Enter.Login + " создал чат");
                        server.Show();
                    }
                });
            }
        }

        public DelegateCommand Connect
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (Validation.EnterValidate(Enter))
                    {
                        TcpClient.ClientStart();
                        Client client = new Client();
                        TcpClient.SendMessage("Пользователь " + Enter.Login + " подключился");
                        client.ShowDialog();
                        TcpClient.SendMessage("/disconnect");
                    }
                });
            }
        }

        public MainViewModel()
        {

        }
    }
}
