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
    public partial class AccountSettings : Page
    {
        UserInformation userinfo = new UserInformation();
        TableColumns tc = new TableColumns();
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tc.UserDetailsColumn();
            List<UserInformationColumns> UserInformationList = tc.Users;
            bool UN = true;
            
            for (int i = 0; i < UserInformationList.Count; i++)
            {
                if (userName.Text == UserInformationList[i].UserName)
                {
                    if (Userid.UserID == UserInformationList[i].UserID)
                    {
                        UN = true;
                    }
                    else
                    {
                        passError.Text = "UserNameTaken";
                        UN = false;
                    }
                }
                
            }
            if (UN == true)
            {
                if (passWord.Text == confPassword.Text)
                {
                    passError.Text = "Account Updated";
                    userinfo.UserValuesUpdate = UserDetails();
                    userinfo.UpdateAccount();
                    passError.Foreground = new SolidColorBrush(Colors.Green);
                    ReturntoMenu();
                }
                else
                {
                    passError.Text = "Passwords don't match.";
                }
            }
            
        }

            Pages.Menu MainMenuPage = new Pages.Menu();
        private void Exit_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(MainMenuPage);
        }
        public Array UserDetails()
        {
            string[] userDetails = new string[4];
            userDetails[0] = userName.Text;
            userDetails[1] = passWord.Text;
            userDetails[2] = firstName.Text;
            userDetails[3] = lastName.Text;
            return userDetails;
        }
        private async void ReturntoMenu()
        {
            await Task.Run(() => Task.Delay(2000));
            NavigationService.Navigate(MainMenuPage);
        }
    }
}

