﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using DigitalJournal.Pages;
using DigitalJournal.Classes;

namespace DigitalJournal.Classes
{
    class Entries
    {        
        SqlCommand cmd;
        SqlConnection con;
        public Array Entryvals { get; set; }

        public void CreateEntry()
        {
            //Created a bew entry, Pulling information from the New Entry Page.
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("Insert Into Entry2(EntryName, Entry, Date, Userid) Values (@EntryName, @Entry, @Date, @UserID)", con);
            cmd.Parameters.AddWithValue("@EntryName", Entryvals.GetValue(0).ToString());
            cmd.Parameters.AddWithValue("@Entry", Entryvals.GetValue(1).ToString());
            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
            cmd.Parameters.AddWithValue("@UserID", Entryvals.GetValue(2));
            cmd.ExecuteNonQuery();
        }
        public void EditEntry(string newEntry, int newEntryID)
        {
            // Saves any edits perfromed on a past entry, pulls information from the Past Entries Page.
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand($"Update Entry2 Set Entry = @Entry Where EntryID  = {newEntryID} ", con);
            cmd.Parameters.AddWithValue("@Entry", newEntry);
            cmd.ExecuteNonQuery();
        }
        public void DeleteEntry(int EntryID)
        {
            con = new SqlConnection("Data Source = DESKTOP-FH9J9JB\\SQLEXPRESS; Initial Catalog = Journal Entries; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand($"Delete From Entry2 Where EntryID = {EntryID} ", con);
            cmd.ExecuteNonQuery();
        }
    }
}
