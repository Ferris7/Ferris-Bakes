using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ferris_Bakes.Models;
using Ferris_Bakes.Data;
using Microsoft.AspNetCore.Http;

namespace Ferris_Bakes.Logic
{
    public class ShoppingCartActions 
    {
        //public string ShoppingCartId { get; set; }

        private readonly FerrisBakesContext _db = new();

        public const string CartSessionKey = "CartId";

        public void AddToSetCart(int id)
        {
            // Retrieve the product from the database.           
            //ShoppingCartId = GetCartId();

            var cartItem = _db.Cart.SingleOrDefault(
                c => c.ProductId == id);
            if (cartItem == null)
            {
                SetOrderModel temp = _db.SetOrderList.SingleOrDefault(
                   p => p.BakeID == id);
                // Create a new cart item if no cart item exists.                 
                cartItem = new CartItemModel
                {
                    ItemId = Guid.NewGuid().ToString(),
                    SetOrder = true,
                    ProductId = id,
                    RecipeId = -1,
                    //CartId = ShoppingCartId,
                    Title = temp.BakeName,
                    Description = temp.Description,
                    Quantity = 1,
                    DateCreated = DateTime.Now,
                    Price = temp.Price,
                    ImgPath = temp.ImgPath
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

        public void AddToRecipeCart(int id)
        {
            // Retrieve the product from the database.           
            //ShoppingCartId = GetCartId();

            var cartItem = _db.Cart.SingleOrDefault(
                c => c.RecipeId == id);
            if (cartItem == null)
            {
                ReciepeModel temp = _db.Reciepes.SingleOrDefault(
                   p => p.ReciepeNumber == id);
                // Create a new cart item if no cart item exists.                 
                cartItem = new CartItemModel
                {
                    ItemId = Guid.NewGuid().ToString(),
                    RecipeId = id,
                    ProductId = -1,
                    RecipeOrder = true,
                    //CartId = ShoppingCartId,
                    Title = temp.Title,
                    Description = temp.Description,
                    Quantity = 1,
                    DateCreated = DateTime.Now,
                    Price = temp.Price,
                    ImgPath = "/bakes/square/no Photo.jpg"
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

        public void DeleteFromSetCart(int id, int prod)
        {
            // Retrieve the product from the database.           
            //ShoppingCartId = GetCartId();

            if (prod == 1)
            {
                var cartItem = _db.Cart.SingleOrDefault(
                                c => c.ProductId == id);
                if (cartItem != null)
                {
                    _db.Cart.Remove(cartItem);
                }
            }
            else
            {
                var cartItem = _db.Cart.SingleOrDefault(
                c => c.RecipeId == id);
                if (cartItem != null)
                {
                    _db.Cart.Remove(cartItem);
                }
            }           
                      
            _db.SaveChanges();
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
    }
}