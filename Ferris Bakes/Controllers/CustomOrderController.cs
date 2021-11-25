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
        private readonly ILogger<CustomOrderController> _logger;

        public CustomOrderController(ILogger<CustomOrderController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string bake)
        {
            CustomOrderModel data = new CustomOrderModel();

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
                case "Cake":
                    data.flavorOptions = new List<string> { "Cheesecake", "Chocolate", "Chocolate With Baileys", "Lemon", "Pumpkin", "Red Velvet", "Sparkling Apple Cider Pound Cake", "Yellow" };
                    data.filling = true;
                    break;
                case "Cupcake":
                    data.flavorOptions = new List<string> { "Chocolate", "Chocolate With Baileys", "Lemon", "Pumpkin", "Red Velvet", "Yellow" };
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

            ViewData["Bake"] = bake;

            return View("Form", data);
         
        }

        public IActionResult Form(CustomOrderModel data)
        {

            ViewData["Bake"] = data.bake;
            
            ViewData["Sizing"] = data.bake switch
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

            return View("Details", data);
            //return View(data);
        }

        public IActionResult Details(CustomOrderModel data)
        {

            ViewData["Bake"] = data.bake;

            ViewData["ID"] = data.CustomBakeID;

            

            return View();
        }

        public IActionResult OrderPlaced(CustomOrderModel data)
        {
            //put in database

            using (var context = new FerrisBakesContext())
            {

                context.CustomOrderList.Add(data);  //Context.Order.ToList

                var cartItem = context.CustomCart.SingleOrDefault(
                    c => c.CustomProductId == data.CustomBakeID);
                if (cartItem == null)
                {
                    // Create a new cart item if no cart item exists.                 
                    cartItem = new CustomCartItemModel
                    {
                        ItemId = Guid.NewGuid().ToString(),
                        CustomProductId = data.CustomBakeID,
                        CustomProduct = context.CustomOrderList.SingleOrDefault(
                        p => p.CustomBakeID == data.CustomBakeID),
                        Quantity = data.size,
                        DateCreated = DateTime.Now
                    };

                    context.CustomCart.Add(cartItem);
                }
                else
                {
                    // If the item does exist in the cart,                  
                    // then add one to the quantity.                 
                    cartItem.Quantity++;
                }

                context.SaveChanges();
            }

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
