using Practical7WPF.ViewModels;
using System.Windows;

namespace Practical7WPF.Views
{
    public partial class Server : Window
    {
        public Server()
        {
            InitializeComponent();
            DataContext = new FirstViewModel();
        }
    }
}
