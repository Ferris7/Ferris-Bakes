﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class ReciepeBook
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
    } 
}
