using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Models.Siniflar;

namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Controllers
{
     public class DefaultController : Controller
     {
          // GET: Default
          Context ctx = new Context();
          public ActionResult Index()
          {
               var bloglar = ctx.Blogs.ToList();
               return View(bloglar);
          }
          public ActionResult About()
          {
               return View();
          }
          public PartialViewResult Partial1()
          {
               return PartialView();
          }

     }
}