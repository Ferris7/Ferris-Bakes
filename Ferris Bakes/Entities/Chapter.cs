using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Entities
{
    public class Chapter
    {
        [Key]
        public int ChapterId { get; set; }
        public int BookID { get; set; }
        public string Title { get; set; }

    }
}
