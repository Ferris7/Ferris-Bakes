using Ferris_Bakes.Data;
using Ferris_Bakes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<UserModel> userManager;

        public AdminController(UserManager<UserModel> usrMgr)
        {
            userManager = usrMgr;
        }

        public IActionResult Index()
        {
            using (var context = new OrderModelContext())
            {
                
                AdminModel temp = new AdminModel { OrderList = context.Order.ToList() };

                return View(temp);
            }
        }

        /*public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(UserModel user)
        {
            if (ModelState.IsValid)
            {
                UserModel appUser = new UserModel
                {
                    UserName = user.FirstName,
                    Email = user.Email
                };

                IdentityResult result = await userManager.CreateAsync(appUser, user.Password);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(user);
        }*/

    }
}
