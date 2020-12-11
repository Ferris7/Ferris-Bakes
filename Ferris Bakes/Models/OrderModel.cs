using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class OrderModel
    {
        [Key]
        public int orderNumber { get; set; }
        public string bake { get; set; }
        public string flavor { get; set; }
        public List<string> flavorOptions { get; set; }
        public int size { get; set; }
        public bool filling { get; set; }
        public int fillFlavor { get; set; }
        public string comment { get; set; }
        public string customerName { get; set; }
        public DateTime date { get; set; }
        public DateTime dueDate { get; set; }
    }
}
