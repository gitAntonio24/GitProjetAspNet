using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;


namespace GitProjectAspNet.Models
{
    public class DBConnection
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection(
            ConfigurationManager.ConnectionStrings["dataBaseConnection"].ConnectionString);
        public static NpgsqlConnection connectionString = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["dataBaseConnection"].ConnectionString);

        public static void Inscription(Utilisateur utilisateur)
        {
            var req = $"INSERT INTO public.\"utilisateur\"(nomutilisateur, motdepasse, email) VALUES ('{utilisateur.NomUtilisateur}', '{utilisateur.MotdePasse}', '{utilisateur.Email}')";
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