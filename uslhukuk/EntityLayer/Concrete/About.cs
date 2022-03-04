using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int HakkimizdaID { get; set; }
        [AllowHtml]
        public string İcerik { get; set; }
    }
}
