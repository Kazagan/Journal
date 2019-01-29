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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Entries_Click(object sender, RoutedEventArgs e)
        {
            Pages.PastEntries p4 = new Pages.PastEntries();
            this.NavigationService.Navigate(p4);
        }

        private void NewEntry_Click(object sender, RoutedEventArgs e)
        {
            Pages.NewEntry p5 = new Pages.NewEntry();
            this.NavigationService.Navigate(p5);
        }
    }
}
