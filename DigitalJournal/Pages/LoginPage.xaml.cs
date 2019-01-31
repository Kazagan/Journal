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
using DigitalJournal.Classes;

namespace DigitalJournal.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        Pages.Menu p3 = new Pages.Menu();
        TableColumns tc = new TableColumns();
        public LoginPage()
        {
            InitializeComponent();

            InitializeComponent();
            userName.Visibility = Visibility.Collapsed;
            passWord.Visibility = Visibility.Collapsed;
            Login2.Visibility = Visibility.Collapsed;
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            Pages.CreatAccountPage p2 = new Pages.CreatAccountPage();
            this.NavigationService.Navigate(p2);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            userName.Visibility = Visibility.Visible;
            passWord.Visibility = Visibility.Visible;
            Login2.Visibility = Visibility.Visible;
        }

        private void Login2_Click(object sender, RoutedEventArgs e)
        {
            tc.UserDetailsColumn();
            List<string> UserNameList = tc.UserNameList;
            List<string> PasswordList = tc.PasswordList;
            bool UN = false;
            string username = userName.Text;
            string password = passWord.Text;
            

            for (int i = 0; i < UserNameList.Count; i++)
            {
                if(username == UserNameList[i])
                {
                    if(password == PasswordList[i])
                    {
                        UN = true;
                    }
                }
            }
            if (UN == true)
            {
                this.NavigationService.Navigate(p3);
            }
            else
            {
                loginError.Text = "Invalid Username or Password";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            picture.Visibility = Visibility.Collapsed;
            
            Goodbye.Text = "Have a good day!";

            Delay();
        }
        private async void Delay()
        {
            await Task.Run(() => Task.Delay(2000));
            Application.Current.Shutdown();
        }
    }
}
