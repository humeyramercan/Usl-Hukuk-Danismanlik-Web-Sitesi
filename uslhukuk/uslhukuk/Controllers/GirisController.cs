
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace uslhukuk.Controllers
{
    [AllowAnonymous]
    public class GirisController : Controller
    {
        UserManager userManager = new UserManager(new EfUserDal());
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name,string sifre)
        {
            var user = userManager.GetUserByUserName(name);
            if (user != null)
            {
                var verified = Crypto.VerifyHashedPassword(user.Password, sifre);

                if (verified == true)
                {
                    FormsAuthentication.SetAuthCookie(name, false);
                    Session["UserName"] = name;
                    return RedirectToAction("KullaniciPaneliBlogListesi", "Blog");
                }
                else
                    return View();
            }
            else
            {
                return View();
            }

        }
        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Giris");
        }
    }
}