using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EntityLayer.Concrete
{
   public class AreasOfExpertise
    {
        [Key]
        public int UzmanlikAlaniID { get; set; }
        public string UzmanlikAlaniBaslik { get; set; }
        [AllowHtml]
        public string İcerik { get; set; }
        public string Resim { get; set; }

    }
}
