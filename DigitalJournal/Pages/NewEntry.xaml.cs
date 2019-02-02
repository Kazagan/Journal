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
    public partial class NewEntry : Page
    {   
        Pages.Menu Menupage = new Pages.Menu();
        Entries CreateNewEntry = new Entries();
        public NewEntry()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Menupage);
        }
        public Array EntryDetails()
        {
            string[] entrydetails = new string[4];
            entrydetails[0] = EntryName.Text;
            entrydetails[1] = Entry.Text;
            entrydetails[2] = $"{Userid.UserID}";
            return entrydetails;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            CreateNewEntry.Entryvals = EntryDetails();
            CreateNewEntry.CreateEntry();
            NavigationService.Navigate(Menupage);
        }
    }
}
