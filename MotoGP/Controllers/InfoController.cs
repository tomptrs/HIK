using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotoGP.Data;
using MotoGP.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoGP.Controllers
{
    public class InfoController : Controller
    {
        private GPContext _context;

        public InfoController(GPContext pContext)
        {
            _context = pContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListRaces()
        {
            ViewData["BannerNr"] = 1;

            var races = _context.Races.OrderBy(r => r.Date).ToList();

            return View(races);
        }

        public IActionResult BuildMap()
        {
            //List<Race> ListOfRaces = new List<Race>();

            //ListOfRaces.Add(new Race() { RaceID = 1, X = 517, Y = 19, Name = "Assen" });
            //ListOfRaces.Add(new Race() { RaceID = 2, X = 859, Y = 249, Name = "Losail Circuit" });
            //ListOfRaces.Add(new Race() { RaceID = 3, X = 194, Y = 428, Name = "Autódromo Termas de Río Hondo" });

            ViewData["BannerNr"] = 1;
            //ViewData["ListOfRaces"] = ListOfRaces;
            //return View();

            var races = _context.Races.ToList();

            return View(races);
        }

        public IActionResult SelectRace()
        {
            ViewData["BannerNr"] = 1;
            return View();
        }

        public IActionResult ShowRace()
        {
            ViewData["BannerNr"] = 1;
            return View();
        }
    }
}
