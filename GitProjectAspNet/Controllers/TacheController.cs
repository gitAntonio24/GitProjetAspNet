using GitProjectAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitProjectAspNet.Controllers
{
    public class TacheController : Controller
    {
        // GET: Tache
        public ActionResult Tache()
        {
            List<Tache> _tache = DBconnectionTache.AfficherListeTache();
            return View(_tache);
        }
    }
}