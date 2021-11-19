using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class ShoppingCartModel
    {
        public List<CartItemModel> Cart { get; set; }
        public List<SetOrderModel> ItemDesctiption { get; set; }
    }
}
