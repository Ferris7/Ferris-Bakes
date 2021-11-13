﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Ferris_Bakes.Entities;


namespace Ferris_Bakes.Models
{
    public class Preference
    {
        [NotMapped] public Ingredients Likes { get; set; }
        [NotMapped] public Ingredients Dislikes { get; set; }

        public bool Vegan { get; set; }

    }
}
