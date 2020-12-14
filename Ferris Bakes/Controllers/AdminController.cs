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
            using (var context = new OrderModelContext())
            {
                
                AdminModel temp = new AdminModel { OrderList = context.Order.ToList() };

                return View(temp);
            }
        }
    }
}
