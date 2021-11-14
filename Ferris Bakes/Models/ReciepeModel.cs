using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Ferris_Bakes.Entities;

namespace Ferris_Bakes.Models
{
    public class ReciepeModel
    {
        [Key]
        public int ReciepeNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public List<string> Ingredients { get; set; }
        [NotMapped] public Ingredients Ingredients { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
    } 
}
