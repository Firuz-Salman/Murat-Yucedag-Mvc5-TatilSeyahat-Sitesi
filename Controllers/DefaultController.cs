using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}