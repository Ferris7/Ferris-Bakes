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
                
                AdminModel temp = new AdminModel { dbCustom = context.CustomOrders.ToList(),
                                                   dbSet = context.SetOrders.ToList()};

                foreach (DatabaseSetOrder s in context.SetOrders)
                {
                    var setItem = context.SetOrderList.SingleOrDefault(
                    c => c.BakeID == s.SetOrderId);

                    if (setItem != null)
                    {
                        temp.SetOrderList.Add(setItem);
                    }

                }

                foreach (DatabaseCustomOrder s in context.CustomOrders)
                {
                    var CustItem = context.CustomOrderList.SingleOrDefault(
                    c => c.CustomBakeID == s.CustomOrderId);

                    if (CustItem != null)
                    {
                        temp.CustomOrderList.Add(CustItem);
                    }

                }

                return View(temp);
            }
        }
    }
}
