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

namespace Journal
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            username.Visibility = Visibility.Collapsed;
            password.Visibility = Visibility.Collapsed;
            Login2.Visibility = Visibility.Collapsed;
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            Page2 p2 = new Page2();
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
            Page3 p3 = new Page3();
            this.NavigationService.Navigate(p3);
        }
    }
}
