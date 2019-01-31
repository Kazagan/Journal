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
        //public List<string> EntryNameList = new List<string>();
        //public List<string> EntryList = new List<string>();
        //public List<string> DateList = new List<string>();
        //public List<string> UserIDList2 = new List<string>();
        Tools Entry = new Tools();
        public List<Tools> Entries = new List<Tools>();

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        List<TableColumns> list = new List<TableColumns>();
        public void UserDetailsColumn()
        {


            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("Select UserID, Username, Password, FirstName, LastName " +
                                "From UserDetail", con);
            SqlDataReader reader = cmd.ExecuteReader();
            string _UID, _UN, _P, _FN, _LN;
            while (reader.Read())
            {
                _UID = reader["UserID"].ToString();
                _UN = reader["UserName"].ToString();
                _P = reader["Password"].ToString();
                _FN = reader["FirstName"].ToString();
                _LN = reader["LastName"].ToString();

                UserNameList.Add(_UN);
                PasswordList.Add(_P);
                UserIDList.Add(_UID);
            }
        }
        public void EntryColumns()
        {
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("Select EntryID, EntryName, Entry, Date, UserID " +
                                "From Entry2", con);
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
        public void TestMethod()
        {
            Entries.Add(new Tools
            {
                EntryName = "string",
                EntryID = 3,
                EntryDate = "string"
            });
        }
    }
}

