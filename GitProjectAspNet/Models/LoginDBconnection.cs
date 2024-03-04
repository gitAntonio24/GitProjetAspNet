using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GitProjectAspNet.Models
{
    public class LoginDBconnection
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection(
            ConfigurationManager.ConnectionStrings["dataBaseConnection"].ConnectionString);

        public static bool authentification(Utilisateur utilisateur)
        {
            var req = $"SELECT nomutilisateur, motdepasse FROM public.utilisateur WHERE nomutilisateur = '{utilisateur.NomUtilisateur}' AND \"motdepasse\" ='{utilisateur.MotDePasse}'";
            var hasUser = false;
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var reader = cmd.ExecuteReader();
                hasUser = reader.HasRows;
                connectionString.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return hasUser;
        }

    }
}