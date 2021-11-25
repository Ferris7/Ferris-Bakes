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
                temp.CustomCart = actions.GetCustomCartItems();
                temp.ItemDescription = new List<SetOrderModel>();

                foreach ( CartItemModel c in temp.Cart)
                {
                    temp.ItemDescription.Add(context.SetOrderList.Find(c.ProductId));
                }

                foreach (CustomCartItemModel c in temp.CustomCart)
                {
                    temp.CustomItemDescription.Add(context.CustomOrderList.Find(c.CustomProductId));
                }

                return View(temp);
            }
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult OrderPlaced(CheckoutOrderModel model)
        {
            using (var context = new FerrisBakesContext())
            {
                foreach (CartItemModel m in context.Cart)
                {
                    var cartItem = context.SetOrderList.SingleOrDefault(
                    c => c.BakeID == m.ProductId);

                    if (cartItem != null)
                    {
                        context.SetOrders.Add(setOrderConvert(model, cartItem));
                    }

                    context.Cart.Remove(m);
                }

                foreach (CustomCartItemModel m in context.CustomCart)
                {
                    var cartItem = context.CustomOrderList.SingleOrDefault(
                    c => c.CustomBakeID == m.CustomProductId);

                    if (cartItem != null)
                    {
                        context.CustomOrders.Add(customOrderConvert(model, cartItem));
                    }

                    context.CustomCart.Remove(m);
                }

                context.SaveChanges();

            }

            return View(model);
        }

        public DatabaseSetOrder setOrderConvert(CheckoutOrderModel order, SetOrderModel cartItem)
        {
            DatabaseSetOrder db = new DatabaseSetOrder();
            db.SetOrderId = cartItem.BakeID;
            db.CustomerFirstName = order.CustomerFirstName;
            db.CustomerLastName = order.CustomerLastName;
            db.CustomerEmail = order.CustomerEmail;
            db.CustomerPhoneNumber = order.CustomerPhoneNumber;
            db.DueDate = order.DueDate;

            return db;
        }

        public DatabaseCustomOrder customOrderConvert(CheckoutOrderModel order, CustomOrderModel cartItem)
        {
            DatabaseCustomOrder db = new DatabaseCustomOrder();
            db.CustomOrderId = cartItem.CustomBakeID;
            db.CustomerFirstName = order.CustomerFirstName;
            db.CustomerLastName = order.CustomerLastName;
            db.CustomerEmail = order.CustomerEmail;
            db.CustomerPhoneNumber = order.CustomerPhoneNumber;
            db.DueDate = order.DueDate;

            return db;
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            ShoppingCartActions actions = new ShoppingCartActions();

            actions.DeleteFromSetCart(id);
            return Ok("Success");
        }

        [HttpPost]
        public IActionResult CustomDelete(int id)
        {
            ShoppingCartActions actions = new ShoppingCartActions();

            actions.DeleteFromCustomCart(id);
            return Ok("Success");
        }

        [HttpPost]
        public IActionResult Add(int id)
        {
            ShoppingCartActions actions = new ShoppingCartActions();

            actions.AddToSetCart(id);
            return Ok("Success");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
