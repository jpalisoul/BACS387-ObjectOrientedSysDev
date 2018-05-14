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

namespace BACS387Group10Project
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            // load arrays here on initialize "..//..//file.txt"
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // take user input of login and username



            Credentials credentials = new Credentials();
            credentials.username = UsernameInput.Text;
            credentials.password = PasswordInput.Text;

            Login login = new Login();
            login.checkCredentials(credentials);
            switch(credentials.cred)
            {
                case 1:
                    MainWindow MainWindow = new MainWindow();
                    MainWindow.Show();
                    this.Close();
                    break;
                case 2:
                    UserWindow UserWindow = new UserWindow();
                    UserWindow.Show();
                    this.Close();
                    break;
                default:
                    UsernameInput.Text = "Error";
                    break;
            }

        }
    }
}
