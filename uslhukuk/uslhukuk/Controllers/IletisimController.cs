using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;


namespace uslhukuk.Controllers
{
    [AllowAnonymous]
    public class IletisimController : Controller
    {
        // GET: İletisim
        [HttpGet]
        public ActionResult Index()
        {
            if (TempData["basarili"] != null)
            {
                ViewBag.basarili = TempData["basarili"].ToString();
            }
            return View();
        }
        [HttpPost]
        public ActionResult Index(string ad, string soyad, string mail, string mesaj)
        {
          
            try
            {
                SmtpClient client = new SmtpClient("xxxx", 00);
                MailMessage msg = new MailMessage();
                msg.To.Add("info@uslhukuk.com");
                msg.From = new MailAddress(mail, ad + " " + soyad);
                msg.Body = mesaj;
                msg.Subject = "İletişim";
                NetworkCredential guvenlik = new NetworkCredential("xxxx", "xxxxx");
                client.Credentials = guvenlik;
                client.EnableSsl = true;
                client.Send(msg);
            
            }
            catch
            {
                TempData["basarisiz"] = "Gönderim sırasında hata oluştu. Lütfen tekrar deneyiniz. Aksi durumda bizlere mail yoluyla ulaşabilirsiniz.";
            }
            TempData["basarili1"] = "Mesajınız gönderilmiştir.";
            TempData["basarili2"] = "Bizimle iletişime geçtiğiniz için teşekkür ederiz.";
            return View();
        }
    }
}