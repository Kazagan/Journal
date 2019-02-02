using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalJournal.Classes
{
    class EntryColumns
    {
        public int EntryID { get; set; }
        public string EntryName { get; set; }
        public string EntryDate { get; set; }
        public string Entry { get; set; }
        public int UserID { get; set; }
    }
    class UserInformationColumns
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    class Userid
    {
        public static int UserID { get; set; }
    }

}
