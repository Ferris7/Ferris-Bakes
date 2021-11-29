using Ferris_Bakes.Data;
using Ferris_Bakes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ferris_Bakes.Logic;

namespace Ferris_Bakes.Controllers
{
    public class CustomOrderController : Controller
    {
        public IActionResult Index(string bake)
        {
            CustomOrderModel data = new();

            if (bake == null)
            {
                return View(data);
            }
     
            data.Bake = bake;

            switch(bake)
            {
                case "Bars": 
                    data.FlavorOptions = new List<string> { "Oat bar", "Strawberry & Cream Bar" };
                    data.Filling = true;
                    break;
                case "Brownies": 
                    data.FlavorOptions = new List<string> { "Regular", "Nutty", "Slutty (add Oreos and Cookie Dough)" };
                    data.Filling = false;
                    break;
                case "Cake":
                    data.FlavorOptions = new List<string> { "Cheesecake", "Chocolate", "Chocolate With Baileys", "Lemon", "Pumpkin", "Red Velvet", "Sparkling Apple Cider Pound Cake", "Yellow" };
                    data.Filling = true;
                    break;
                case "Cupcake":
                    data.FlavorOptions = new List<string> { "Chocolate", "Chocolate With Baileys", "Lemon", "Pumpkin", "Red Velvet", "Yellow" };
                    data.Filling = true;
                    break;
                case "Cookies":
                    data.FlavorOptions = new List<string> { "Chocolate Chip", "Chocolate Crinkle", "Sugar" };
                    data.Filling = false;
                    break;
                case "Pastry":
                    data.FlavorOptions = new List<string> { "Jam & Cream Cheese Pinwheel", "Strudel" };
                    data.Filling = true;
                    break;
                case "Pie":
                    data.FlavorOptions = new List<string> { "Apple", "Chocolate"};
                    data.Filling = false;
                    break;
                default: 
                    data.FlavorOptions = null;
                    data.Filling = false;
                    break;
            }

            ViewData["Bake"] = bake;

            return View("Form", data);
         
        }

        public IActionResult Form(CustomOrderModel data)
        {

            ViewData["Bake"] = data.Bake;
            
            ViewData["Sizing"] = data.Bake switch
            {
                "Bars" => "Size is number of pans.",
                "Brownies" => "Size is number of pans.",
                "Cake" => "Size is number of cakes",
                "Cupcake" => "Size is dozens of cupcakes.",
                "Cookies" => "Size is in dozens.",
                "Pastry" => "Size is in individual items.",
                "Pie" => "Size is in individual items.",
                _ => "Size is in individual items.",
            };

            data.CalculatePrice();


            return View("Details", data);
            //return View(data);
        }

        public IActionResult Details(CustomOrderModel data)
        {

            ViewData["Bake"] = data.Bake;

            data.ConfirmationNumber = Guid.NewGuid().ToString();
            data.Date = DateTime.Now;

            ViewData["ID"] = data.ConfirmationNumber;

            using (var context = new FerrisBakesContext())
            {
                context.CustomOrders.Add(data);  //Context.Order.ToList

                context.SaveChanges();
            }

            return View("OrderPlaced", data);
        }

        public IActionResult OrderPlaced()
        {
            //put in database

            

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
