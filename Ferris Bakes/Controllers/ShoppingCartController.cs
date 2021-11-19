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
    public class ShoppingCartController : Controller
    {
        private readonly ILogger<ShoppingCartController> _logger;

        public ShoppingCartController(ILogger<ShoppingCartController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            using (var context = new FerrisBakesContext())
            {

                ShoppingCartModel temp = new ShoppingCartModel();

                ShoppingCartActions actions = new ShoppingCartActions();

                temp.Cart = actions.GetCartItems();
                temp.ItemDesctiption = new List<SetOrderModel>();

                foreach ( CartItemModel c in temp.Cart)
                {
                    temp.ItemDesctiption.Add(context.SetOrder.Find(c.ProductId));
                }

                return View(temp);
            }
        }

        public IActionResult Delete(int id)
        {
            ShoppingCartActions actions = new ShoppingCartActions();

            actions.DeleteFromCart(id);
            return View("Index");
        }

        public IActionResult Add(int id)
        {
            ShoppingCartActions actions = new ShoppingCartActions();

            actions.AddToCart(id);
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
