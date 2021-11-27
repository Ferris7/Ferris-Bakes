using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Models
{
    public class CustomOrderModel
    {
        [Key]
        public int CustomBakeID { get; set; }
        public string ConfirmationNumber { get; set; }
        public string bake { get; set; }
        public string flavor { get; set; }
        [NotMapped] public List<string> flavorOptions { get; set; }
        public int size { get; set; }
        public double Price { get; set; }
        public string Frosting { get; set; }
        public bool filling { get; set; }
        public string fillFlavor { get; set; }
        public string comment { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime date { get; set; }
        public DateTime dueDate { get; set; }

        public List<string> BakeList = new List<string> { "Bars", "Brownies", "Cake", "Cupcake", "Cookies", "Pastry", "Pie" };

        public List<string> FrostingList = new List<string> { "Baileys", "Blueberry", "Chocolate", "Cream Cheese", "Lavendar", "None", "Strawberry", "Vanilla" };

        public List<string> FillingList = new List<string> { "Blackberry", "Blueberry", "Mango", "Peach", "Strawberry", "Raspberry"};
    
        public string calculatePrice()
        {
            Price = 9.99;

            if (bake == "Cupcake")
                Price += 5;
            else if (bake == "Cake")
                Price += 10;
            else if (bake == "Pastry")
                Price += 10;

            if (fillFlavor != null)
                Price += 5;

            if (flavor == "Lemon")
                Price += 2;
            else if (flavor == "Jam & Cream Cheese Pinwheel")
                Price += 5;
            else if (flavor == "Cheesecake")
                Price += 5;
            
            if (Frosting == "Lavendar")
                Price += 2;

            if (Frosting == "Baileys" || flavor == "Chocolate With Baileys")
                Price += 5;

            return String.Format("{0:0.00}", Price);
        }
    } 
}
