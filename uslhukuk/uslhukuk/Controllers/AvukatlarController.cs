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
    public class AvukatlarController : Controller
    {
        // GET: Avukatlar

        LawyerManager lm = new LawyerManager(new EfLawyerDal());
        public ActionResult Index()
        {
            var avukatlar = lm.LawyerList();
            return View(avukatlar);
        }


        [HttpGet]
        public ActionResult AvukatEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AvukatEkle(Lawyer lawyer)
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
                    lawyer.Resim = "/Resimler/" + fileName + fileExtension;

                }
            }
            lm.AddLawyer(lawyer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AvukatGuncelle(int id)
        {
            var avukat = lm.GetLawyerById(id);
            TempData["AvukatResim"] = avukat.Resim;
            return View(avukat);
        }
        [HttpPost]
        public ActionResult AvukatGuncelle(Lawyer lawyer)
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
                    lawyer.Resim = "/Resimler/" + fileName + fileExtension;

                }
                else if (TempData["AvukatResim"]!=null)
                {
                    lawyer.Resim = TempData["AvukatResim"].ToString();
                }
            }
            lm.UpdateLawyer(lawyer);
            return RedirectToAction("Index");
        }

        public ActionResult AvukatKaldir(int id)
        {
            var avukat = lm.GetLawyerById(id);
            lm.DeleteLawyer(avukat);
            return RedirectToAction("Index");
        }
    }
}