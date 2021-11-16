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
        public string Ingredients { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public int BookId { get; set; }
        public int ChapterId { get; set; }
    } 
}
