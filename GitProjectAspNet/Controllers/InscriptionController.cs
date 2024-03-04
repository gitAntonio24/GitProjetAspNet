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
                return Content($"<h1>Inscription reussi");
            }
            else
            {
                return Content($"<h1>Inscription echoué</h1>");
            }
            
        }


        // GET: Inscription/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inscription/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inscription/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inscription/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inscription/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inscription/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inscription/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
