using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace uslhukuk.Controllers
{
    [AllowAnonymous]
    public class StajBasvurusuController : Controller
    {
        // GET: StajBasvurusu
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string ad,string soyad,string mail, /*string telefon,*/ string eklemekIstedikleriniz, HttpPostedFileBase ozgecmis)
        {
            try
            {
                SmtpClient client = new SmtpClient("xxxx", 000);
                MailMessage msg = new MailMessage();
                msg.To.Add("info@uslhukuk.com");
                msg.From = new MailAddress(mail, ad + " " + soyad);

                if(eklemekIstedikleriniz!=null)
                msg.Body = eklemekIstedikleriniz;
                msg.Subject = "Staj Başvurusu";
                if (ozgecmis != null)
                {
                    string fileName = Path.GetFileName(ozgecmis.FileName);
                    msg.Attachments.Add(new Attachment(ozgecmis.InputStream, fileName));
                }

                NetworkCredential guvenlik = new NetworkCredential("xxxxx", "xxxxx");
                client.Credentials = guvenlik;
                client.EnableSsl = true;
                client.Send(msg);

            }
            catch
            {
                TempData["basarisiz-staj"] = "Gönderim sırasında hata oluştu. Lütfen tekrar deneyiniz. Aksi durumda bizlere mail yoluyla ulaşabilirsiniz.";
            }

            TempData["basarili"] = "Başvurunuz alınmıştır. İlginiz için teşekkür ederiz.";
        

            return View();
        }
    }
}