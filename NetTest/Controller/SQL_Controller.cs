﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace NetTest
{
    public partial class Controller
    {
        void Verbindungsaufbau()
        {
            try
            {
                string ConnectionString = "Server=95.111.235.48;Database=Mannschaftsverwaltung;Uid=Schule;Pwd=12345678;";
                SQL_Verbindung = new MySqlConnection(ConnectionString);
                SQL_Verbindung.Open();
            } catch
            {

            }        
        }

        void Testdaten()
        {

        }
    }
}