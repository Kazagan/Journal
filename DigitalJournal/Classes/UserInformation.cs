using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using DigitalJournal.Pages;

namespace DigitalJournal.Classes
{
    class UserInformation
    {
        SqlCommand cmd;
        SqlConnection con;
        public Array uservals { get; set; }
        public Array uservals2 { get; set; }
        

        public void CreateAccount()
        {
            // my database connection
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("Insert Into UserDetail(Username, Password, FirstName, LastName) Values (@Username, @Password, @FirstName, @LastName)", con);
            cmd.Parameters.AddWithValue("@Username", uservals.GetValue(0).ToString());
            cmd.Parameters.AddWithValue("@Password", uservals.GetValue(1).ToString());
            cmd.Parameters.AddWithValue("@FirstName", uservals.GetValue(2).ToString());
            cmd.Parameters.AddWithValue("@LastName", uservals.GetValue(3).ToString());
            cmd.ExecuteNonQuery();
        }  
        public void UpdateAccount()
        {
            // my database connection
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand($"Update UserDetail Set Username = @Username, Password = @Password , FirstName = @FirstName, LastName = @LastName Where UserID = {Userid.UserID}", con);
            cmd.Parameters.AddWithValue("@Username", uservals2.GetValue(0).ToString());
            cmd.Parameters.AddWithValue("@Password", uservals2.GetValue(1).ToString());
            cmd.Parameters.AddWithValue("@FirstName", uservals2.GetValue(2).ToString());
            cmd.Parameters.AddWithValue("@LastName", uservals2.GetValue(3).ToString());
            cmd.ExecuteNonQuery();
        }
    }
}
