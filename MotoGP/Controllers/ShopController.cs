using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoGP.Controllers
{
    public class ShopController : Controller
    {
        // GET: /<controller>/
        public IActionResult OrderTicket()
        {
            ViewData["BannerNr"] = 3;
            return View();
        }

        public IActionResult ConfirmOrder()
        {
            ViewData["BannerNr"] = 3;
            return View();
        }
    }
}
