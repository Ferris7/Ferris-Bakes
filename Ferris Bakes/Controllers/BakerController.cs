using Ferris_Bakes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Ferris_Bakes.Models;
using Ferris_Bakes.Entities;
using Ferris_Bakes.Logic;

namespace Ferris_Bakes.Controllers
{
    public class BakerController : Controller
    {
        private readonly ILogger<GalleryController> _logger;

        public BakerController(ILogger<GalleryController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Preference UserPreference)
        {
            HelpingBaker HelpingBaker = new HelpingBaker();

            UserPreference.Results.AddRange(HelpingBaker.GetLikeableRecieps(UserPreference));

            return View("Results", UserPreference);
        }

        public IActionResult Results(Preference UserPreference)
        {
            return View(UserPreference);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
