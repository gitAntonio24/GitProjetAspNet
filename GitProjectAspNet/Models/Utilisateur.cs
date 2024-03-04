using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitProjectAspNet.Models
{
    public class Utilisateur
    {
        private string _nomUtilisateur;
        private string _motDePasse;
        private string _email;

        public Utilisateur(string nomUtilisateur, string motDePasse, string email)
        {
            _nomUtilisateur = nomUtilisateur;
            _motDePasse = motDePasse;
            _email = email;
        }

        public Utilisateur() { }
     
        public string  Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string MotDePasse
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }

        public string NomUtilisateur
        {
            get { return _nomUtilisateur; }
            set { _nomUtilisateur = value; }
        }

    }
}