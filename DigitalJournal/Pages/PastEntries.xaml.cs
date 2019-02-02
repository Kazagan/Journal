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
    public partial class PastEntries : Page
    {
        TableColumns tc = new TableColumns();
        public PastEntries()
        {
            InitializeComponent();
            tc.EntryColumns();
            entryList.ItemsSource = tc.Entries;
        }
        Pages.Menu p3 = new Pages.Menu();
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Menu Menupage = new Pages.Menu();
            NavigationService.Navigate(Menupage);
        }
        Entries ent = new Entries();
        EntryColumns entrycolumns = new EntryColumns();
        private void EntryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            entrycolumns = (EntryColumns)entryList.SelectedItem;
            entry.Text = entrycolumns.Entry;
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            entrycolumns = (EntryColumns)entryList.SelectedItem;
            string editEntry = entry.Text;
            int editEntryID = entrycolumns.EntryID;
            ent.EditEntry(editEntry, editEntryID);
            NavigationService.Navigate(p3);
        }
    }
}
