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

        public List<string> UserNameList = new List<string>();
        public List<string> PasswordList = new List<string>();
        public List<string> UserIDList = new List<string>();
        public List<Tools> Entries = new List<Tools>();
        public List<UserTools> Users = new List<UserTools>();

        SqlCommand cmd;
        SqlConnection con;
        public void UserDetailsColumn()
        {
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("Select UserID, Username, Password From UserDetail", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Users.Add(new UserTools
                {
                    UserID = Convert.ToInt32(reader["UserID"]),
                    UserName = reader["Username"].ToString(),
                    Password = reader["Password"].ToString(),

                });
            }
        }
        public void EntryColumns()
        {
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand($"Select EntryID, EntryName, Entry, Date From Entry2 Where UserID = {Userid.UserID}", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Entries.Add(new Tools
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

