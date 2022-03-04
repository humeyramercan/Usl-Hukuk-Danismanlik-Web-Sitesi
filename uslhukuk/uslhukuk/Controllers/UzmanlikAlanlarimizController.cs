using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uslhukuk.Controllers
{
    [AllowAnonymous]
    public class UzmanlikAlanlarimizController : Controller
    {
        // GET: UzmanlikAlanlarimiz
        AreasOfExpertiseManager aem = new AreasOfExpertiseManager(new EfAreasOfExpertiseDal());
        public ActionResult Index()
        {
            var uzmanlikAlanlari = aem.AreasOfExpertiseList();
            return View(uzmanlikAlanlari);
        }

        public ActionResult UzmanlikAlanlarimizListe()
        {
            var uzmanlikAlanlari = aem.AreasOfExpertiseList();
            return View(uzmanlikAlanlari);
        }
        [HttpGet]
        public ActionResult UzmanlikAlaniEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UzmanlikAlaniEkle(AreasOfExpertise areasOfExpertise)
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(Request.Files[0].FileName);
                    string fileExtension = Path.GetExtension(Request.Files[0].FileName);
                    string path = "~/Resimler/" + fileName + fileExtension;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    areasOfExpertise.Resim = "/Resimler/" + fileName + fileExtension;

                }
            }
            aem.AddAreasOfExpertise(areasOfExpertise);
            return RedirectToAction("UzmanlikAlanlarimizListe");
        }

        [HttpGet]
        public ActionResult UzmanlikAlaniGuncelle(int id)
        {
            var uzmanlikAlani = aem.GetAreasOfExpertiseById(id);
            TempData["UzmanlikAlaniResim"] = uzmanlikAlani.Resim;
            return View(uzmanlikAlani);
        }
        [HttpPost]
        public ActionResult UzmanlikAlaniGuncelle(AreasOfExpertise areasOfExpertise)
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(Request.Files[0].FileName);
                    string fileExtension = Path.GetExtension(Request.Files[0].FileName);
                    string path = "~/Resimler/" + fileName + fileExtension;
                    Request.Files[0].SaveAs(Server.MapPath(path));
                    areasOfExpertise.Resim = "/Resimler/" + fileName + fileExtension;

                }
                else if (TempData["UzmanlikAlaniResim"] != null)
                {
                    areasOfExpertise.Resim = TempData["UzmanlikAlaniResim"].ToString();
                }
            }
            aem.UpdateAreasOfExpertise(areasOfExpertise);
            return RedirectToAction("UzmanlikAlanlarimizListe");
        }

        public ActionResult UzmanlikAlaniKaldir(int id)
        {
            var uzmanlikAlani = aem.GetAreasOfExpertiseById(id);
            aem.DeleteAreasOfExpertise(uzmanlikAlani);
            return RedirectToAction("UzmanlikAlanlarimizListe");
        }
    }
}