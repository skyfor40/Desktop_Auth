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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLesson1_bvv
{
    public partial class MainWindow : Window
    {
        private const string LOGIN = "admin";
        private const string PASS = "123456";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text.Equals(LOGIN) && passPasswordBox.Password.Equals(PASS))
            {
                MessageBox.Show("Authorization successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Authorization failed!", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
