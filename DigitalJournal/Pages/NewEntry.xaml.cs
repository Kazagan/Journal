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
    /// Interaction logic for NewEntry.xaml
    /// </summary>
    
    public partial class NewEntry : Page
    {
        
        Pages.Menu p3 = new Pages.Menu();
        Entries a = new Entries();
        public NewEntry()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(p3);
        }
        public Array EntryDetails()
        {
            int _UserID = Userid.UserID;
            string[] entrydetails = new string[4];
            entrydetails[0] = EntryName.Text;
            entrydetails[1] = Entry.Text;
            entrydetails[2] = $"{_UserID}";
            return entrydetails;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            a.Entryvals = EntryDetails();
            a.CreateEntry();
            NavigationService.Navigate(p3);
        }
    }
}
