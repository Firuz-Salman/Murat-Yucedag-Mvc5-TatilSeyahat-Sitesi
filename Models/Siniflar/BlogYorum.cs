using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Models.Siniflar
{
     public class BlogYorum
     {
          public IEnumerable<Blog> Blogs { get; set; }
          public Blog Blog { get; set; }
          public IEnumerable<Yorumlar> Yorumlars { get; set; }
     }
}