using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows;

namespace GitProjectAspNet.Models
{
    public class DBconnectionTache
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection(
           ConfigurationManager.ConnectionStrings["dataBaseConnection"].ConnectionString);

        public static void InsererTache(Tache tache) {
            var req = $"INSERT INTO public.\"tache\"(tachenomutilisateur, description, statut) VALUES ( '{tache.TacheNomUtilisateur}','{tache.Description}','{tache.Statut}')";

            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery();
                connectionString.Close();              
            }
            catch (Exception ex)
            {
                throw ex;
            }    
    }

        public static void SupprimerTache(int id)
        {
            var req = $"DELETE FROM public.\"tache\" WHERE idtache='{id}'";
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery();
                connectionString.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<Tache> AfficherListeTache(string username) { 
            
            List<Tache> liste = new List<Tache>();
            var req = $"SELECT * FROM public.tache where tachenomutilisateur='{username}' ORDER BY idtache ASC";
            var conn = connectionString;
            try 
            {
                conn.Open();
                var cmd = new NpgsqlCommand(req,conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tache tache = new Tache(reader.GetInt32(0),
                                                reader.GetString(1),
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

        public static void ModifierTache(int idTache, Tache tache)
        {
            var req = $"UPDATE public.\"tache\" SET description='{tache.Description}', statut='{tache.Statut}' WHERE idtache='{idTache}'";

            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery();
                connectionString.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}