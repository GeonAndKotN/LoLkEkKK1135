using LoLkEkKK1135.Model;
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
        }

        private void CloseRegWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void RegNewUser(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
                if (users.Name.ToString() != Login.Text)
                {
                    users.Name += Login.Text;
                    
                }
                else
                {
                    MessageBox.Show("Пользователь уже зарегистрирован!");
                    
                }
            
        }
    }
}
