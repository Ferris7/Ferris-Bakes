using Ferris_Bakes.Data;
using Ferris_Bakes.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new FerrisBakesContext())
            {
                
                AdminModel temp = new AdminModel { dbSet = context.SetOrders.ToList()};

                foreach (DatabaseSetOrder s in context.SetOrders)
                {
                    var setItem = context.SetOrderList.SingleOrDefault(
                    c => c.BakeID == s.SetOrderId);

                    if (setItem != null)
                    {
                        temp.SetOrderList.Add(setItem);
                    }

                }

               return View(temp);
            }
        }
    }
}
