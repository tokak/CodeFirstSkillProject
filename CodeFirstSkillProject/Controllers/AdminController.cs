using CodeFirstSkillProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstSkillProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context db = new Context();
        public ActionResult Index()
        {
            var result = db.Yeteneks.ToList();
            return View(result);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(Yetenek y)
        {
            
            db.Yeteneks.Add(y);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var result = db.Yeteneks.Find(id);
            db.Yeteneks.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var result = db.Yeteneks.Find(id);

            return View("YetenekGetir",result);
        }
        [HttpPost]
        public ActionResult YetenekGetir(Yetenek y)
        {
            var result = db.Yeteneks.Find(y.Id);
            result.Aciklama = y.Aciklama;
            result.Deger = y.Deger;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}