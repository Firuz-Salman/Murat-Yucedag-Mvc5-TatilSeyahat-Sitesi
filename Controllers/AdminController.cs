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
    }
}