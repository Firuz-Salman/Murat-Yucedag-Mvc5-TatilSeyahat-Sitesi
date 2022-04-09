using Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Models.Siniflar;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web;
using System;

namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Controllers
{
     public class BlogController : Controller
     {
          // GET: Blog
          Context ctx = new Context();
          BlogYorum by = new BlogYorum();
          public ActionResult Index()
          {
               
               by.Blogs = ctx.Blogs.OrderByDescending(x=>x.Tarih).Take(5).ToList();
               by.Yorumlars = ctx.Yorumlars.ToList();
               return View(by);
          }
          public ActionResult BlogDetay(int id)
          {
               by.Blog = ctx.Blogs.Where(x => x.ID == id).FirstOrDefault();
               by.Yorumlars = ctx.Yorumlars.Where(x => x.BlogID == id).ToList();
               return View(by);
          }
     }
}