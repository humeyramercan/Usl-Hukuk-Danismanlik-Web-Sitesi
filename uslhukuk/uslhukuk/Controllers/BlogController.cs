using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uslhukuk.Controllers
{
   
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        Context c = new Context();
        // GET: Blog
        [AllowAnonymous]
        public ActionResult Index(int page=1)
        {
            var blogs = c.Blogs.OrderByDescending(x => x.BlogTarihi).Where(x=>x.BlogDurumu==true).ToPagedList(page,6);
            return View(blogs);
        }
        [AllowAnonymous]
        public ActionResult BlogDetay(int id)
        {
            var blog = bm.GetBlogById(id);
            return View(blog);
        }
    
        [HttpGet]
        public ActionResult KullaniciPaneliYeniBlogEkleme()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KullaniciPaneliYeniBlogEkleme(Blog blog)
        {
            blog.BlogTarihi= DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogDurumu = true;
            bm.AddBlog(blog);
            return RedirectToAction("KullaniciPaneliBlogListesi");
        }
        [HttpGet]
        public ActionResult KullaniciPaneliBlogGuncelleme(int id)
        {
            var blog = bm.GetBlogById(id);
            return View(blog);
        }
        [HttpPost]
        public ActionResult KullaniciPaneliBlogGuncelleme(Blog blog)
        {
            blog.BlogTarihi = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogDurumu = true;           

            bm.UpdateBlog(blog);
            return RedirectToAction("KullaniciPaneliBlogListesi");
        }

        public ActionResult KullaniciPaneliBlogListesi()
        {
            var blogs = bm.GetBlogsByStatus(true);
            return View(blogs);
        }
        public ActionResult KullaniciPaneliBlogKaldirma(int id)
        {
            var blog = bm.GetBlogById(id);
            blog.BlogDurumu = false;
            bm.UpdateBlog(blog);
            return RedirectToAction("KullaniciPaneliBlogListesi");
        }

        public ActionResult KullaniciPaneliKaldirilanBloglarListesi()
        {
            var blogs = bm.GetBlogsByStatus(false);
            return View(blogs);
        }
        public ActionResult KullaniciPaneliBlogAktiflestirme(int id)
        {
            var blog = bm.GetBlogById(id);
            blog.BlogDurumu = true;
            bm.UpdateBlog(blog);
            return RedirectToAction("KullaniciPaneliKaldirilanBloglarListesi");
        }

        [HttpGet]
        public ActionResult KullaniciPaneliPasifBlogGuncelleme(int id)
        {
            var blog = bm.GetBlogById(id);
            return View(blog);
        }
        [HttpPost]
        public ActionResult KullaniciPaneliPasifBlogGuncelleme(Blog blog)
        {
            blog.BlogTarihi = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogDurumu = false;
            bm.UpdateBlog(blog);
            return RedirectToAction("KullaniciPaneliKaldirilanBloglarListesi");
        }
    }
}