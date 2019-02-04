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
    /// Interaction logic for CreatAccountPage.xaml
    /// </summary>
    public partial class CreatAccountPage : Page
    {
        LoginPage LoginPage = new LoginPage();
        UserInformation UserInfo = new UserInformation();
        TableColumns tc = new TableColumns();
        public CreatAccountPage()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            tc.UserDetailsColumn();
            List<UserInformationColumns> UserInformationList = tc.Users;
            bool UN = true;

            if (userName.Text.Length <= 10)
            {
                if (passWord.Text.Length <=10)
                {
                    for (int i = 0; i < UserInformationList.Count; i++)
                    {
                        if (userName.Text == UserInformationList[i].UserName)
                        {
                            PassError.Text = "UserNameTaken";
                            UN = false;
                        }
                    }
                    if (UN == true)
                    {
                        if (passWord.Text == confPassword.Text)
                        {
                            PassError.Text = "Account Created!";
                            UserInfo.UserValues = Userdetails();
                            UserInfo.CreateAccount();
                            PassError.Foreground = new SolidColorBrush(Colors.Green);
                            ReturntoLogin();
                        }
                        else{ PassError.Text = "Passwords do not match"; }
                    }
                }
                else { PassError.Text = "Password too long, please keep it to 10 characters"; }
            }
            else { PassError.Text = "UserName too long, please keep it to 10 characters"; }
        }
        //Exit Button Click
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(LoginPage);
        }
        public Array Userdetails()
        {
            string[] userdetails = new string[4];
            userdetails[0] = userName.Text;
            userdetails[1] = passWord.Text;
            userdetails[2] = firstName.Text;
            userdetails[3] = lastName.Text;
            return userdetails;
        }
        public async void ReturntoLogin()
        {
            await Task.Run(() => Task.Delay(2000));
            NavigationService.Navigate(LoginPage);
        }
    }
}
