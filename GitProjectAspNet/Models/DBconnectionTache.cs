using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Windows;

namespace GitProjectAspNet.Models
{
    public class DBconnectionTache
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection(
           ConfigurationManager.ConnectionStrings["dataBaseConnection"].ConnectionString);

        public static void InsererTache() { }

        public static List<Tache> AfficherListeTache() { 
            
            List<Tache> liste = new List<Tache>();

            return liste;
        }
    }
}