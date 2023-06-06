using CodeFirstSkillProject.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstSkillProject.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        Context db = new Context();
        public ActionResult Index()
        {
            var result = db.Yeteneks.ToList();

            return View(result) ;
        }
    }
}