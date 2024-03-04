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
    }

}