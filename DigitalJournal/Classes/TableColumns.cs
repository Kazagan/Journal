using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using DigitalJournal.Classes;

namespace DigitalJournal.Classes
{
    class TableColumns
    {
        public List<EntryColumns> Entries = new List<EntryColumns>();
        public List<UserInformationColumns> Users = new List<UserInformationColumns>();
        SqlCommand cmd;
        SqlConnection con;
        public void UserDetailsColumn()
        {
            // Creates a list of the object UserInformationColumns, created in Tools.
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("Select UserID, Username, Password, FirstName, LastName From UserDetail", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Users.Add(new UserInformationColumns
                {
                    UserID = Convert.ToInt32(reader["UserID"]),
                    UserName = reader["Username"].ToString(),
                    Password = reader["Password"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString()
                });
            }
        }
        public void EntryColumns()
        {
            // Created a list of objects EntryColumns, created in Tools.
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand($"Select EntryID, EntryName, Entry, Date From Entry2 Where UserID = {Userid.UserID}", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Entries.Add(new EntryColumns
                {
                    EntryName = reader["EntryName"].ToString(),
                    EntryID = Convert.ToInt32(reader["EntryID"]),
                    EntryDate = reader["Date"].ToString(),
                    Entry = reader["Entry"].ToString()
                });
            }
        }
    }
}

