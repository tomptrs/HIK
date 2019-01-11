using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotoGP.Models;

namespace MotoGP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Menu()
        {
            int willekeurigGetal = (new System.Random(DateTime.Now.Millisecond)).Next(1, 5);

            ViewData["BannerNr"] = willekeurigGetal;

            return View();
        }
    }
}
