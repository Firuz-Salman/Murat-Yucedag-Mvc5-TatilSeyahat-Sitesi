using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Murat_Yucedag_Mvc5_TatilSeyahat_Sitesi.Models.Siniflar
{
     public class Blog
     {
          [Key]
          public int ID { get; set; }
          public string Baslik { get; set; }
          public DateTime Tarih { get; set; }
          public string Aciklama { get; set; }
          public string BlohImage { get; set; }
          public ICollection<Yorumlar> Yorumlars { get; set; }
     }
}