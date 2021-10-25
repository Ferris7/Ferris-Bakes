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
        public string BakeName { get; set; }
        public string BakeType { get; set; }
        public string Flavor { get; set; }
        public int Size { get; set; }
        public string Frosting { get; set; }
        public string FillFlavor { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    } 
}
