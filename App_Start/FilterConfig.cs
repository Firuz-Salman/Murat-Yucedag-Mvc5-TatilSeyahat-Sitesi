using System.Web;
using System.Web.Mvc;

namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi
{
     public class FilterConfig
     {
          public static void RegisterGlobalFilters(GlobalFilterCollection filters)
          {
               filters.Add(new HandleErrorAttribute());
          }
     }
}
