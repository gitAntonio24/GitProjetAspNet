using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace GitProjectAspNet.Models
{
    public class DBconnectionTache
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection(
           ConfigurationManager.ConnectionStrings["dataBaseConnection"].ConnectionString);

        public static void InsererTache() { }

        public static List<Tache> AfficherListeTache(string username) { 
            
            List<Tache> liste = new List<Tache>();
            var req = $"SELECT * FROM public.tache where tachenomutilisateur='{username}'";
            var conn = connectionString;
            try 
            {
                conn.Open();
                var cmd = new NpgsqlCommand(req,conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tache tache = new Tache(reader.GetString(1),
                                                reader.GetString(2),
                                                reader.GetBoolean(3));

                        liste.Add(tache);
                    }
                }
                conn.Close();
            }
            catch(Exception ex) 
            {
                throw ex; 
            }

            return liste;
        }
    }
}