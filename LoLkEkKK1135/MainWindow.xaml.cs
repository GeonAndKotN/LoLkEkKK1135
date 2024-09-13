using LoLkEkKK1135.Model;
using LoLkEkKK1135.MySQL;
using LoLkEkKK1135.View;
using LoLkEkKK1135.ViewModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoLkEkKK1135
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            new MySqlConnect();
        }

        private void OpenRegWindow(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            this.Close();
            registerWindow.ShowDialog();
        }

        private void OpenProductWindow(object sender, RoutedEventArgs e)
        {
            List<Users> users = new List<Users>();
            users = MainVM.GetUsers();
            foreach (var item in users)
            {
                if (Login.Text == item.Name && Password.Password == item.Password)
                {
                    ProductWindow productWindow = new ProductWindow();
                    this.Close();
                    productWindow.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Неверный Логин или Пароль!");
        }
    }
}