using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class ReciepeBook
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<ReciepeModel> Reciepes { get; set; }
        public virtual List<ReciepeBook> Chapters { get; set; }
    } 
}
