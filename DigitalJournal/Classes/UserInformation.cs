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
        SqlDataAdapter da;
        public Array uservals { get; set; }
        //TableColumns column = new TableColumns();
       
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
    }
}
