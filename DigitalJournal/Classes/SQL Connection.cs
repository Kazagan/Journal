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
    class DataConnection
    {
        private SqlConnection _con;
        public SqlCommand _cmd;
        private SqlDataAdapter _da;
        private DataTable _dt;

        public void SqlDbConnect()
        {
            _con = new SqlConnection("Data Source=DESKTOP-FH9J9JB\\SQLEXPRESS;Initial Catalog=Journal Entries;Integrated Security=True");
            _con.Open();
        }

    }
}
