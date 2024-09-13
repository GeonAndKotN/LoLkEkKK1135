using ConsoleApp47;
using LoLkEkKK1135.Model;
using LoLkEkKK1135.MySQL;
using LoLkEkKK1135.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LoLkEkKK1135.View
{
    /// <summary>
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            new MySqlConnect();
        }

        private void CloseRegWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void RegNewUser(object sender, RoutedEventArgs e)
        {
            List<Users> users = new List<Users>();
            users = MainVM.GetUsers();
            foreach (var item in users)
            {
                if (item.Name.ToString() != Login.Text)
                {
                    Users uuss = new Users
                    {
                        Name = Login.Text,
                        Password = Password.Text,
                    };
                    users.Add(uuss);
                    return;
                }
            }
            MessageBox.Show("Пользователь уже зарегистрирован!");
        }
    }
}
