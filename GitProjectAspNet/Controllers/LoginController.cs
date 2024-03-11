using GitProjectAspNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitProjectAspNet.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(Utilisateur utilisateur)
        {
            
            if (LoginDBconnection.authentification(utilisateur))
            {
                Session["username"] = utilisateur.NomUtilisateur;
                return RedirectToRoute("Tache");  // OR RedirectToAction("TodoList", "TodoTask");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            Session["username"] = null;
            return RedirectToAction("Index", "Home");
        }

    }
}
