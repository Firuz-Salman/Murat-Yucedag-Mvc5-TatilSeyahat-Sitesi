using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Models.Siniflar;

namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Controllers
{
     public class AdminController : Controller
     {
          // GET: Admin
          Context ctx = new Context();
          public ActionResult Index()
          {
               return View(ctx.Blogs.ToList());
          }
          public ActionResult YeniBlog()
          {
               Blog blog = new Blog();
               return View(blog);
          }
          [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
               ctx.Blogs.Add(blog);
               ctx.SaveChanges();
             return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
               var silinenBlog = ctx.Blogs.Find(id);
               ctx.Blogs.Remove(silinenBlog);
               ctx.SaveChanges();
             return RedirectToAction("Index");
        }
    }
}