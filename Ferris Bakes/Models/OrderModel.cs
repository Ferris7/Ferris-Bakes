﻿using System;
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
        [System.ComponentModel.DataAnnotations.Schema.NotMapped] public List<string> flavorOptions { get; set; }
        public int size { get; set; }
        public string Frosting { get; set; }
        public bool filling { get; set; }
        public string fillFlavor { get; set; }
        public string comment { get; set; }
        public string customerName { get; set; }
        public DateTime date { get; set; }
        public DateTime dueDate { get; set; }

        public List<string> BakeList = new List<string> { "Bars", "Brownies", "Cake/Cupcake", "Cookies", "Pastry", "Pie" };
    } 
}
