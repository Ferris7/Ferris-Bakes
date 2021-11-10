using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class ReciepeModel
    {
        [Key]
        public int ReciepeNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public bool Vegitarian { get; set; }
        public bool Vegan { get; set; }
        public bool Nuts { get; set; }
        public bool LactoseIntolerant { get; set; }
    } 
}
