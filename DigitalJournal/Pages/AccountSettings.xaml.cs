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
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using DigitalJournal.Classes;

namespace DigitalJournal.Pages
{
    /// <summary>
    /// Interaction logic for AccountSettings.xaml
    /// </summary>
    public partial class AccountSettings : Page
    {
        LoginPage p1 = new LoginPage();
        UserInformation a = new UserInformation();
        TableColumns tc = new TableColumns();
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tc.UserDetailsColumn();
            List<string> UserNameList = tc.UserNameList;
            bool UN = false;
            foreach (string _u in UserNameList)
            {
                if(userName.Text == _u)
                {
                    UN = true;
                }
                else
                {
                    UN = false;
                }
            }
            if (UN == false)
            {
                if (passWord.Text != confPassword.Text)
                {
                    passError.Text = "Passwords do not Match";
                }
                else
                {
                    passError.Text = "Account Updated!";
                    a.uservals2 = userdetails();
                    a.UpdateAccount();
                    passError.Foreground = new SolidColorBrush(Colors.Green);
                    
                }
            }
            else
            {
                passError.Text = "UserName Taken";
            }
        }

        private void Exit_Click_1(object sender, RoutedEventArgs e)
        {
            Pages.Menu p3 = new Pages.Menu();
            this.NavigationService.Navigate(p3);
        }
        public Array userdetails()
        {
            string[] userDetails = new string[4];
            userDetails[0] = userName.Text;
            userDetails[1] = passWord.Text;
            userDetails[2] = firstName.Text;
            userDetails[3] = lastName.Text;
            return userDetails;
        }
    }
}
