using Ferris_Bakes.Data;
using Ferris_Bakes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ferris_Bakes.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new FerrisBakesContext())
            {
                SetOrderListModel temp = new();

                foreach (SetOrderModel Bake in context.SetOrderList)
                {
                    switch (Bake.BakeType)
                    {
                        case "Cake":
                            {
                                temp.Cakes.Add(Bake);
                                break;
                            }
                        case "Cookies":
                            {
                                temp.Cookies.Add(Bake);
                                break;
                            }
                        case "Cupcakes":
                            {
                                temp.Cupcakes.Add(Bake);
                                break;
                            }
                        case "Pastry":
                            {
                                temp.Pastry.Add(Bake);
                                break;
                            }
                        case "Holiday":
                            {
                                temp.Holiday.Add(Bake);
                                break;
                            }
                        case "Misc":
                            {
                                temp.Misc.Add(Bake);
                                break;
                            }
                        default:
                            {
                                Debug.Print("Bad Bake type");
                                break;
                            }
                    }
                }

                return View(temp);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
