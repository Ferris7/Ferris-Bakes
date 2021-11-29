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

            using var context = new FerrisBakesContext();

            ShoppingCartModel temp = new();

            ShoppingCartActions actions = new();

            temp.Cart = actions.GetCartItems();

            return View(temp);
        }

        public IActionResult Checkout()
        {
            return View("Checkout");
        }

        public IActionResult OrderPlaced(CheckoutOrderModel model)
        {
            model.OrderConfirmation = Guid.NewGuid().ToString();

            using (var context = new FerrisBakesContext())
            {
                foreach (CartItemModel m in context.Cart)
                {

                    if (m != null)
                    {
                        context.SetOrders.Add(SetOrderConvert(model, m));
                    }                   

                    context.Cart.Remove(m);
                }
                context.SaveChanges();

            }

            return View(model);
        }


        public DatabaseSetOrder SetOrderConvert(CheckoutOrderModel order, CartItemModel cartItem)
        {
            DatabaseSetOrder db = new();
            db.OrderConfirmation = order.OrderConfirmation;
            db.RecipeOrderId = cartItem.RecipeId;
            db.Title = cartItem.Title;
            db.Description = cartItem.Description;
            db.SetOrder = cartItem.SetOrder;
            db.RecipeOrder = cartItem.RecipeOrder;
            db.SetOrderId = cartItem.ProductId;
            db.CustomerFirstName = order.CustomerFirstName;
            db.CustomerLastName = order.CustomerLastName;
            db.CustomerEmail = order.CustomerEmail;
            db.CustomerPhoneNumber = order.CustomerPhoneNumber;
            db.DatePlaced = DateTime.Now;
            db.DueDate = order.DueDate;

            return db;
        }

        [HttpPost]
        public IActionResult Delete(int id, int prod)
        {
            ShoppingCartActions actions = new();

            actions.DeleteFromSetCart(id, prod);
            return Ok("Success");
        }

        [HttpPost]
        public IActionResult Add(int id)
        {
            ShoppingCartActions actions = new();

            actions.AddToSetCart(id);
            return Ok("Success");
        }

        [HttpPost]
        public IActionResult AddRecipe(int id)
        {
            ShoppingCartActions actions = new();

            actions.AddToRecipeCart(id);
            return Ok("Success");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
