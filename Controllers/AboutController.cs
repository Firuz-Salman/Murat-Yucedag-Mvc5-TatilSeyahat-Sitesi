using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Models.Siniflar;

namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Controllers
{
    public class AboutController : Controller
    {

          // GET: About
          Context ctx = new Context();
        public ActionResult Index()
        {
               var degerler = ctx.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}