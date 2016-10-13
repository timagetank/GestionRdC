using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace GestionnaireRageDuCode.Controllers
{
    public class SujetController : Controller
    {
        // GET: Sujet
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sujet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sujet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sujet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Sujet/Edit/5
        [HttpPost]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sujet/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Sujet/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

        // POST: Sujet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
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