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
        public string Bake { get; set; }
        public string Flavor { get; set; }
        [NotMapped] public List<string> FlavorOptions { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
        public string Frosting { get; set; }
        public bool Filling { get; set; }
        public string FillFlavor { get; set; }
        public string Comment { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }

        public List<string> BakeList = new() { "Bars", "Brownies", "Cake", "Cupcake", "Cookies", "Pastry", "Pie" };

        public List<string> FrostingList = new() { "Baileys", "Blueberry", "Chocolate", "Cream Cheese", "Lavendar", "None", "Strawberry", "Vanilla" };

        public List<string> FillingList = new() { "Blackberry", "Blueberry", "Mango", "Peach", "Strawberry", "Raspberry"};
    
        public string CalculatePrice()
        {
            Price = 9.99;

            if (Bake == "Cupcake")
                Price += 5;
            else if (Bake == "Cake")
                Price += 10;
            else if (Bake == "Pastry")
                Price += 10;

            if (FillFlavor != null)
                Price += 5;

            if (Flavor == "Lemon")
                Price += 2;
            else if (Flavor == "Jam & Cream Cheese Pinwheel")
                Price += 5;
            else if (Flavor == "Cheesecake")
                Price += 5;
            
            if (Frosting == "Lavendar")
                Price += 2;

            if (Frosting == "Baileys" || Flavor == "Chocolate With Baileys")
                Price += 5;

            return String.Format("{0:0.00}", Price);
        }
    } 
}
