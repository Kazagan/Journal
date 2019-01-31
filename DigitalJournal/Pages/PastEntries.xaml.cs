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
    /// Interaction logic for PastEntries.xaml
    /// </summary>
    public partial class PastEntries : Page
    {
        Tools t = new Tools();
        TableColumns tc = new TableColumns();
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public PastEntries()
        {
            InitializeComponent();

            tc.EntryColumns();

            entryList.ItemsSource = tc.Entries;
        }

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
    }
}
