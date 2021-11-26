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
        public double TotalPrice { get; set; }

        public double calculatePrice()
        {
            TotalPrice = 0;

            foreach (CartItemModel m in Cart)
            {
                TotalPrice += m.Price;
            }

            return TotalPrice;
        }
    }
}
