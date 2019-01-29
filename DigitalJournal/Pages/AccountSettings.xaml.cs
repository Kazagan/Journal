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
    /// Interaction logic for AccountSettings.xaml
    /// </summary>
    public partial class AccountSettings : Page
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Password.Text != confPassword.Text)
            {
                PassError.Text = "Passwords do not Match";
            }
            else
            {
                PassError.Text = "";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pages.Menu p3 = new Pages.Menu();
            this.NavigationService.Navigate(p3);
        }
    }
}
