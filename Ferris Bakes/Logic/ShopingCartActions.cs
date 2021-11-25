using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ferris_Bakes.Models;
using Ferris_Bakes.Data;
using Microsoft.AspNetCore.Http;

namespace Ferris_Bakes.Logic
{
    public class ShoppingCartActions : IDisposable
    {
        //public string ShoppingCartId { get; set; }

        private FerrisBakesContext _db = new FerrisBakesContext();

        public const string CartSessionKey = "CartId";

        public void AddToSetCart(int id)
        {
            // Retrieve the product from the database.           
            //ShoppingCartId = GetCartId();

            var cartItem = _db.Cart.SingleOrDefault(
                c => c.ProductId == id);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.                 
                cartItem = new CartItemModel
                {
                    ItemId = Guid.NewGuid().ToString(),
                    ProductId = id,
                    //CartId = ShoppingCartId,
                    Product = _db.SetOrderList.SingleOrDefault(
                   p => p.BakeID == id),
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };

                _db.Cart.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,                  
                // then add one to the quantity.                 
                cartItem.Quantity++;
            }
            _db.SaveChanges();
        }

        public void DeleteFromSetCart(int id)
        {
            // Retrieve the product from the database.           
            //ShoppingCartId = GetCartId();

            var cartItem = _db.Cart.SingleOrDefault(
                c => c.ProductId == id);
            if (cartItem != null)
            {
                _db.Cart.Remove(cartItem);
            }
                      
            _db.SaveChanges();
        }

        public void DeleteFromCustomCart(int id)
        {
            // Retrieve the product from the database.           
            //ShoppingCartId = GetCartId();

            var cartItem = _db.CustomCart.SingleOrDefault(
                c => c.CustomProductId == id);
            if (cartItem != null)
            {
                _db.CustomCart.Remove(cartItem);
            }

            _db.SaveChanges();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }

        public string GetCartId()
        {
            /*
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
            */
            return "1";
        }

        public List<CartItemModel> GetCartItems()
        {
            //ShoppingCartId = GetCartId();

            return _db.Cart.ToList();
        }

        public List<CustomCartItemModel> GetCustomCartItems()
        {
            //ShoppingCartId = GetCartId();

            return _db.CustomCart.ToList();
        }
    }
}