using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EntityLayer.Concrete
{
    public class Lawyer
    {
        [Key]
        public int AvukatID { get; set; }
        public string UnvanAdSoyad { get; set; }
        [AllowHtml]
        public string Hakkinda { get; set; }
        public string Resim { get; set; }
        public string Mail { get; set; }
    }
}
