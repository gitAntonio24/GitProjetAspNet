using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitProjectAspNet.Models
{
    public class Utilisateur
    {
        private string _nomutilisateur;
        private string _motdepasse;
        private string _email;

        public string NomUtilisateur
        {
            get { return _nomutilisateur; }
            set { _nomutilisateur = value; }
        }

        public string MotdePasse
        {
            get { return _motdepasse; }
            set { _motdepasse = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


    }
}