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

               by.Blogs = ctx.Blogs.OrderByDescending(x => x.Tarih).ToList();
               by.Yorumlars = ctx.Yorumlars.ToList();
               return View(by);
          }
          public ActionResult BlogDetay(int id)
          {
               by.Blog = ctx.Blogs.Where(x => x.ID == id).FirstOrDefault();
               by.Yorumlars = ctx.Yorumlars.Where(x => x.BlogID == id).ToList();
               return View(by);
          }

          public ActionResult YorumYap(int? blogID)
          {
               ViewBag.BlogID = blogID;
               return PartialView();
          }

          [HttpPost]
          public PartialViewResult YorumYap(Yorumlar2 yrm)
          {
               Yorumlar yorum = new Yorumlar() 
               { 
               BlogID = yrm.BlogID,
               KullaniciAdi = yrm.KullaniciAdi,
               Mail = yrm.Mail,
               Yorum = yrm.Yorum               
               };

               ctx.Yorumlars.Add(yorum);
               ctx.SaveChanges();

               //ViewBag.BlogID = yrm.BlogID;

               return PartialView();
          }
          public class Yorumlar2 : Yorumlar
          {
               //public int ID { get; set; }
               //public string KullaniciAdi { get; set; }
               //public string Mail { get; set; }
               //public string Yorum { get; set; }
               //public int BlogID { get; set; }
               //public virtual Blog Blog { get; set; }
          }
     }
}



