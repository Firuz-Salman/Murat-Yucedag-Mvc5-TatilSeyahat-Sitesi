using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Models.Siniflar;


namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Controllers
{
     [Authorize]
     public class AdminController : Controller
     {
          // GET: Admin
          Context ctx = new Context();
          public ActionResult Index()
          {
               if (object.Equals(ViewBag.indexDetay, null))
                    ViewBag.detay = null;

               else ViewBag.detay = ViewBag.indexDetay;

               return View(ctx.Blogs.ToList());
          }


          public ActionResult BlogDetail(int? id)
          {
               //Blog blog = null;
               //if (id != null) blog = ctx.Blogs.Find(id);
               Blog blog = ctx.Blogs.Find(id);

               return View(blog);
          }


          [HttpPost]
          public ActionResult BlogEkle(Blog blog)
          {
               ctx.Blogs.Add(blog);
               ctx.SaveChanges();

               ViewBag.indexDetay = new Dictionary<string, string> { { "blogAdi", blog.Baslik }, { "blogStatusu", "eklendi" } };

               return RedirectToAction("Index");
          }

          [HttpPost]
          public ActionResult BlogGuncelle(Blog updatedBlog)
          {
               var oldBlog = ctx.Blogs.Find(updatedBlog.ID);
               oldBlog.Aciklama = updatedBlog.Aciklama;
               oldBlog.Baslik = updatedBlog.Baslik;
               oldBlog.BlogImage = updatedBlog.BlogImage;
               oldBlog.Tarih = updatedBlog.Tarih;
               ctx.SaveChanges();

               ViewBag.indexDetay = new Dictionary<string, string> { { "blogAdi", updatedBlog.Baslik }, { "blogStatusu", "güncellendi" } };

               return View("Index", ctx.Blogs.ToList());
          }


          public ActionResult BlogSil(int id)
          {
               var silinenBlog = ctx.Blogs.Find(id);
               ctx.Blogs.Remove(silinenBlog);
               ctx.SaveChanges();

               ViewBag.indexDetay = new Dictionary<string, string> { { "blogAdi", silinenBlog.Baslik }, { "blogStatusu", "silindi" } };

               return View("Index", ctx.Blogs.ToList());
          }

          public ActionResult YorumListele()
          {
               var yorumlar = ctx.Yorumlars.ToList();
               return View(yorumlar);
          }

          public ActionResult YorumSil(int id)
          {
               var silinenYorum = ctx.Yorumlars.Find(id);
               ctx.Yorumlars.Remove(silinenYorum);
               ctx.SaveChanges();

               return RedirectToAction("YorumListele");
          }

          public ActionResult YorumDetail(int id)
          {
               Yorumlar yorum = ctx.Yorumlars.Find(id)  ;

               return View(yorum);
          }
          [HttpPost]
          public ActionResult YorumGuncelle(Yorumlar updatedYorum)
          {
               var oldYorum = ctx.Yorumlars.Find(updatedYorum.ID);
               oldYorum.KullaniciAdi = updatedYorum.KullaniciAdi;
               oldYorum.Mail = updatedYorum.Mail;
               oldYorum.Yorum = updatedYorum.Yorum;
               ctx.SaveChanges();

               //ViewBag.indexDetay = new Dictionary<string, string> { { "blogAdi", updatedYorum.Baslik }, { "blogStatusu", "güncellendi" } };

               return RedirectToAction("YorumListele");
          }
     }
}