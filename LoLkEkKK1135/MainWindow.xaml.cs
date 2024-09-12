using LoLkEkKK1135.Model;
using LoLkEkKK1135.View;
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
        }

        private void OpenRegWindow(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            this.Close();
            registerWindow.ShowDialog();
        }

        private void OpenProductWindow(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "")
            {
                ProductWindow productWindow = new ProductWindow();
                this.Close();
                productWindow.ShowDialog();
            }
            else
                MessageBox.Show("Неверный Логин или Пароль!");
        }
    }
}