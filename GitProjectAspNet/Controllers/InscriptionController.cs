using GitProjectAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitProjectAspNet.Controllers
{
    public class InscriptionController : Controller
    {
        // GET: Inscription
        [HttpGet]
        public ActionResult Inscription()
        {
            return View();
        }

        public ActionResult Inscription(Utilisateur utilisateur)
        {
           if(utilisateur != null)
            {
                DBConnection.Inscription(utilisateur);
                return RedirectToRoute("Login");
            }
            else
            {
                return Content($"<h1>Inscription echoué</h1>");
            }
            
        }
    }
}
