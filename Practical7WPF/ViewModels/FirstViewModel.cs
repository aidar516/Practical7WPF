using Practical7WPF.Models;
using Practical7WPF.Views.Helpers;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Windows;

namespace Practical7WPF.ViewModels
{
    internal class FirstViewModel : BindingHelper
    {
        public static ObservableCollection<string> Message { get; set; } = new ObservableCollection<string>();
        public static ObservableCollection<string> Users { get; set; } = new ObservableCollection<string>();
        public string Text { get; set; }

        public DelegateCommand Send
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (Text == "/disconnect")
                        Application.Current.Shutdown();
                    else
                        TcpClient.SendMessage(Text);

                });
            }
        }

        public FirstViewModel() 
        {
            Text = "";
        }
    }
}
