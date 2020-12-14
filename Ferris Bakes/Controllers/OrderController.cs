using Ferris_Bakes.Data;
using Ferris_Bakes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }       

        

        public IActionResult Index(string bake)
        {
            OrderModel data = new OrderModel();

            if (bake == null)
            {
                return View(data);
            }
     
            data.bake = bake;

            switch(bake)
            {
                case "Bars": 
                    data.flavorOptions = new List<string> { "Oat bar", "Strawberry & Cream Bar" };
                    data.filling = true;
                    break;
                case "Brownies": 
                    data.flavorOptions = new List<string> { "Regular", "Nutty", "Slutty (add Oreos and Cookie Dough)" };
                    data.filling = false;
                    break;
                case "Cake/Cupcake":
                    data.flavorOptions = new List<string> { "Cheesecake", "Chocolate", "Chocolate With Baileys", "Lemon", "Pumpkin", "Red Velvet", "Sparkling Apple Cider Pound Cake", "Yellow" };
                    data.filling = true;
                    break;
                case "Cookies":
                    data.flavorOptions = new List<string> { "Chocolate Chip", "Chocolate Crinkle", "Sugar" };
                    data.filling = false;
                    break;
                case "Pastry":
                    data.flavorOptions = new List<string> { "Jam & Cream Cheese Pinwheel", "Strudel" };
                    data.filling = true;
                    break;
                case "Pie":
                    data.flavorOptions = new List<string> { "Apple", "Chocolate"};
                    data.filling = false;
                    break;
                default: 
                    data.flavorOptions = null;
                    data.filling = false;
                    break;
            }

            if (data.bake == "Cake/Cupcake")
            {
                ViewData["Message"] = "Please put in the comment box whether you would like a Cake or Cupcakes.";
            }

            ViewData["Bake"] = data.bake;

            ViewData["Sizing"] = bake switch
            {
                "Bars" => "Size is number of pans.",
                "Brownies" => "Size is number of pans.",
                "Cake/Cupcake" => "Size is layers of cake or dozens of cupcakes.",
                "Cookies" => "Size is in dozens.",
                "Pastry" => "Size is in individual items.",
                "Pie" => "Size is in individual items.",
                _ => "Size is in individual items.",
            };

            return View("Form", data);
         

            
        }

        public IActionResult Form(OrderModel data)
        {
            ViewData["ID"] = data.orderNumber;
           
            return View("OrderPlaced", data);
        }

        public IActionResult OrderPlaced(OrderModel data)
        {
            //put in database

            data.date = DateTime.Now;

            using (var context = new OrderModelContext())
            {

                context.Order.Add(data);  //Context.Order.ToList
                context.SaveChanges();
            }

            return View(data);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
