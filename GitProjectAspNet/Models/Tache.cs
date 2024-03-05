using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GitProjectAspNet.Models
{
    public class Tache
    {
		private int _idTache;
		private string _tacheNomUtilisateur;
		private string _description;
		private Boolean _statut;

        public Tache() { }

        public Tache(int idTache, string tacheNomUtilisateur, string description, bool statut)
        {
            _idTache = idTache;
            _tacheNomUtilisateur = tacheNomUtilisateur;
            _description = description;
            _statut = statut;
        }

        public Tache(string tacheNomUtilisateur, string description, bool statut)
        {
            _tacheNomUtilisateur = tacheNomUtilisateur;
            _description = description;
            _statut = statut;
        }

        public int IdTache
        {
            get { return _idTache; }
            set { _idTache = value; }
        }

        public Boolean Statut
		{
			get { return _statut; }
			set { _statut = value; }
		}

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		public string TacheNomUtilisateur
        {
			get { return _tacheNomUtilisateur; }
			set { _tacheNomUtilisateur = value; }
		}
	}
}