using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class SetOrderModel
    {
        [Key]
        public int BakeID { get; set; }
        public string Bake { get; set; }
        public string Flavor { get; set; }
        public int Size { get; set; }
        public string Frosting { get; set; }
        public string FillFlavor { get; set; }
        public DateTime Date { get; set; }
    } 
}
