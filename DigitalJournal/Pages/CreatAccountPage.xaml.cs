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

namespace DigitalJournal.Pages
{
    /// <summary>
    /// Interaction logic for CreatAccountPage.xaml
    /// </summary>
    public partial class CreatAccountPage : Page
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public CreatAccountPage()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (password.Text != confPassword.Text)
            {
                PassError.Text = "Passwords do not Match";
            }
            else
            {
                PassError.Text = "";
                con=new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
                con.Open();
                cmd = new SqlCommand("Insert Into UserDetail(Username, Password, FirstName, LastName) Values (@Username, @Password, @FirstName, @LastName)", con);
                cmd.Parameters.AddWithValue("@username", userName.Text);
                cmd.Parameters.AddWithValue("@Password", password.Text);
                cmd.Parameters.AddWithValue("@FirstName", firstName.Text);
                cmd.Parameters.AddWithValue("@LastName", lastName.Text);
                cmd.ExecuteNonQuery();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pages.LoginPage p1 = new Pages.LoginPage();
            this.NavigationService.Navigate(p1);
        }
    }
}
