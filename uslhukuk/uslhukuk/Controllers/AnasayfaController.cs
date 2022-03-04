using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uslhukuk.Controllers
{
    [AllowAnonymous]
    public class AnasayfaController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var hakkimizda = abm.GetAboutList();
            return View(hakkimizda);
        }

        public ActionResult Hakkimizdaİcerik()
        {
            var hakkimizda = abm.GetAboutList();
            return View(hakkimizda);
        }
        [HttpGet]
        public ActionResult HakkimizdaGuncelle(int id)
        {
            var hakkimizda = abm.GetAboutById(id);
            return View(hakkimizda);
        }
        [HttpPost]
        public ActionResult HakkimizdaGuncelle(About about)
        {
            abm.UpdateAbout(about);
            return RedirectToAction("Hakkimizdaİcerik");
        }

    }
}