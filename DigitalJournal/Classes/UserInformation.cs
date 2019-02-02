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
        public Array UserValues { get; set; }
        public Array UserValuesUpdate { get; set; }
        public void CreateAccount()
        {
            // Used to Create Account information and push it to the database From CreateAccount Page.
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("Insert Into UserDetail(Username, Password, FirstName, LastName) Values (@Username, @Password, @FirstName, @LastName)", con);
            cmd.Parameters.AddWithValue("@Username", UserValues.GetValue(0).ToString());
            cmd.Parameters.AddWithValue("@Password", UserValues.GetValue(1).ToString());
            cmd.Parameters.AddWithValue("@FirstName", UserValues.GetValue(2).ToString());
            cmd.Parameters.AddWithValue("@LastName", UserValues.GetValue(3).ToString());
            cmd.ExecuteNonQuery();
        }  
        public void UpdateAccount()
        {
            // Used to push updates to the database, taken from AccountSettings page
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand($"Update UserDetail Set Username = @Username, Password = @Password , FirstName = @FirstName, LastName = @LastName Where UserID = {Userid.UserID}", con);
            cmd.Parameters.AddWithValue("@Username", UserValuesUpdate.GetValue(0).ToString());
            cmd.Parameters.AddWithValue("@Password", UserValuesUpdate.GetValue(1).ToString());
            cmd.Parameters.AddWithValue("@FirstName", UserValuesUpdate.GetValue(2).ToString());
            cmd.Parameters.AddWithValue("@LastName", UserValuesUpdate.GetValue(3).ToString());
            cmd.ExecuteNonQuery();
        }
    }
}
