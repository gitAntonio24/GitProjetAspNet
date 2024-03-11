﻿using GitProjectAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace GitProjectAspNet.Controllers
{
    public class TacheController : Controller
    {
        // GET: Tache
        public ActionResult Tache()
        {  
            if (Session["username"] == null)
            {
                return RedirectToRoute("Login");
            }
            else {
                List<Tache> _tache = DBconnectionTache.AfficherListeTache(Session["username"].ToString());
                return View(_tache);
            }
        }

        public ActionResult Create(FormCollection form) {

            var tache = new Tache(Session["username"].ToString(), form["tachedescription"], form["state"] == null ? false : true);
            DBconnectionTache.InsererTache(tache);
           
            return RedirectToAction("Tache");
        }

        public ActionResult Delete(int id)
        {
            DBconnectionTache.SupprimerTache(id);
            return RedirectToAction("Tache");
        }

        [HttpPost]
        public ActionResult EditTask(FormCollection form)
        {
            var tache = new Tache(Session["username"].ToString(), form["tachenoms"], form["states"] == null ? false : true);
            DBconnectionTache.ModifierTache(int.Parse(form["idTache"]), tache);
            return RedirectToAction("Tache");
        }

    }
}