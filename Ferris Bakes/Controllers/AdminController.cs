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

                AdminModel temp = new AdminModel { DBSet = context.SetOrders.ToList() };
                temp.CustomOrderList = new List<CustomOrderModel>();

                foreach (CustomOrderModel c in context.CustomOrders)
                {
                    temp.CustomOrderList.Add(c);
                }

                return View(temp);
            }
        }

        [HttpPost]
        public IActionResult CheckAdmin(String Username, String Password)
        {
            if (Username.Equals("BakingPenguin"))
            {
                if (Password.Equals("Bueller7!"))
                    return Ok("Success");
            }
            return Ok("Failure");
        }
    }
}
