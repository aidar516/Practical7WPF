using Practical7WPF.ViewModels;
using System.Windows;

namespace Practical7WPF.Views
{
    public partial class Client : Window
    {
        public Client()
        {
            InitializeComponent();
            DataContext = new SecondViewModel();
        }
    }
}
