using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public DateTime BlogTarihi { get; set; }
        [AllowHtml]
        public string İcerik { get; set; }

        public bool BlogDurumu { get; set; }
    }
}
