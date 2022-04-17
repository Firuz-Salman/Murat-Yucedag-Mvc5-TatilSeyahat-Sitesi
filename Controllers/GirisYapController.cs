using Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Controllers
{
     public class GirisYapController : Controller
     {
          Context ctx = new Context();
          // GET: GirisYap
          public ActionResult Index()
          {
               return View();
          }
          public ActionResult Login()
          {
               return View();
          }
          [HttpPost]
          public ActionResult Login(Admin admin)
          {
               var bilgiler = ctx.Admins.FirstOrDefault(x => x.Kullanici == admin.Kullanici && x.Sifre == admin.Sifre);
               if (bilgiler != null)
               {
                    FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                    Session["Kullanici"] = bilgiler.Kullanici.ToString();
                    return RedirectToAction("Index", "Admin");
               }
               else
               {
                    return View();
               }
          }

          public ActionResult Logout()
          {
               FormsAuthentication.SignOut();
               return RedirectToAction("Login");
          }
     }
}