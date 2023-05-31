using Practical7WPF.ViewModels;
using System.Windows;

namespace Practical7WPF.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
