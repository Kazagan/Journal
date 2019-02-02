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
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Entries_Click(object sender, RoutedEventArgs e)
        {PastEntries PastEntriesPage = new Pages.PastEntries(); NavigationService.Navigate(PastEntriesPage);}

        private void NewEntry_Click(object sender, RoutedEventArgs e)
        {NewEntry NewEntriesPage = new Pages.NewEntry(); NavigationService.Navigate(NewEntriesPage);}

        private void EditAccount_Click(object sender, RoutedEventArgs e)
        {AccountSettings AccountSettingsPage = new Pages.AccountSettings(); NavigationService.Navigate(AccountSettingsPage);}

        private void Exit_Click(object sender, RoutedEventArgs e)
        { LoginPage LogingPage = new Pages.LoginPage(); NavigationService.Navigate(LogingPage);}
    }
}
