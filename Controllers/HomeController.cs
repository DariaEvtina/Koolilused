using Koolilused.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Koolilused.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Meie Koolitus on uuenduslik ja tööturu vajadustele suunatud elukestva õppe keskus. ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakti lehe";

            return View();
        }
    KoolitusContext db = new KoolitusContext();
        public ActionResult Opitajad()
        {
            IEnumerable<Opetaja> Opitajad = db.Opetajas;
            return View(Opitajad);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Opetaja op)
        {
            db.Opetajas.Add(op);
            db.SaveChanges();
            return RedirectToAction("Opitajad");

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Opetaja g = db.Opetajas.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            return View(g);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Opetaja g = db.Opetajas.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            db.Opetajas.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Opitajad");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Opetaja g = db.Opetajas.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            return View(g);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditConfirmed(Opetaja op)
        {
            db.Entry(op).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Opitajad");
        }
    }
}