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

namespace DigitalJournal.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

            InitializeComponent();
            username.Visibility = Visibility.Collapsed;
            password.Visibility = Visibility.Collapsed;
            Login2.Visibility = Visibility.Collapsed;
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            Pages.CreatAccountPage p2 = new Pages.CreatAccountPage();
            this.NavigationService.Navigate(p2);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            username.Visibility = Visibility.Visible;
            password.Visibility = Visibility.Visible;
            Login2.Visibility = Visibility.Visible;
        }

        private void Login2_Click(object sender, RoutedEventArgs e)
        {
            Pages.Menu p3 = new Pages.Menu();
            this.NavigationService.Navigate(p3);
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
