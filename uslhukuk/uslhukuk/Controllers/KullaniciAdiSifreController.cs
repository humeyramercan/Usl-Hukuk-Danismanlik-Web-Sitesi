using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace uslhukuk.Controllers
{
    public class KullaniciAdiSifreController : Controller
    {
        // GET: KullaniciAdiSifre
        UserManager um = new UserManager(new EfUserDal());
        [HttpGet]
        public ActionResult Index()
        {
            
            var user = um.GetUserById(1);
            return View(user);
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            user.Password = Crypto.HashPassword(user.Password);
            um.UpdateUser(user);
            ViewBag.basarili = "Güncelleme işlemi gerçekleşti.";
            return View();
        }
    }
}