using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class ShoppingCartModel
    {
        [Key]
        public int OrderID {get; set;}
        public List<CartItemModel> Cart { get; set; }
        public List<SetOrderModel> ItemDescription { get; set; }
        public List<CustomCartItemModel> CustomCart { get; set; } 
        public List<CustomOrderModel> CustomItemDescription { get; set; }
    }
}
