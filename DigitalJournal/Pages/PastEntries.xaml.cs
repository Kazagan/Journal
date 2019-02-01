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
    /// Interaction logic for PastEntries.xaml
    /// </summary>
    public partial class PastEntries : Page
    {
        Entries ent = new Entries();
        Tools t = new Tools();
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
            Pages.Menu p3 = new Pages.Menu();
            this.NavigationService.Navigate(p3);
        }

        private void EntryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            t = (Tools)entryList.SelectedItem;
            entry.Text = t.Entry;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            t = (Tools)entryList.SelectedItem;
            string editEntry = entry.Text;
            int editEntryID = t.EntryID;
            ent.EditEntry(editEntry, editEntryID);
            NavigationService.Navigate(p3);
        }
    }
}
