using Practical7WPF.Models;
using System.Text.RegularExpressions;
using System.Windows;

namespace Practical7WPF.ViewModels
{
    public class Validation
    {
        public static bool EnterValidate(MainModel enter)
        {
            if (enter.Login is null || enter.Login is "")
                MessageBox.Show("Вы не ввели логин пользователя");
            if (enter.Ip is null || enter.Ip is "")
                MessageBox.Show("Вы не ввели IP-адрес");
            else if (Regex.IsMatch(enter.Ip, "[^0-9.]+", RegexOptions.IgnoreCase))
                return true;
            else
                MessageBox.Show("Вы ввели неправильный IP-адрес");
            return false;
        }
    }
}
