using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uslhukuk.Controllers
{
    [AllowAnonymous]
    public class EkibimizController : Controller
    {
        // GET: Ekibimiz
        LawyerManager lm = new LawyerManager(new EfLawyerDal());
        public ActionResult Index()
        {
            var avukatlar = lm.LawyerList();
            return View(avukatlar);
        }
    }
}