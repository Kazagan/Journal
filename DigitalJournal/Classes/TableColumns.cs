using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DigitalJournal.Classes
{
    class TableColumns
    {
        public List<string> UserNameList = new List<string>();
        public List<string> PasswordList = new List<string>();
        public List<string> UserNameandPassword = new List<string>();

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        List<TableColumns> list = new List<TableColumns>();
        public void UserDetailsColumn()
        {
            
            
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("Select Username, Password, FirstName, LastName " +
                                "From UserDetail", con);
            SqlDataReader reader = cmd.ExecuteReader();
            string _UN, _P, _FN, _LN;
            while (reader.Read())
            {
                _UN = reader["UserName"].ToString();
                _P = reader["Password"].ToString();
                _FN = reader["FirstName"].ToString();
                _LN = reader["LastName"].ToString();

                UserNameList.Add(_UN);
                PasswordList.Add(_P);
            }
        }
    }
}

