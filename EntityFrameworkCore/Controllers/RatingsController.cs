using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkCore.Data;
using EntityFrameworkCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCore.Controllers
{
    public class RatingsController : Controller
    {
        private MovieContext _context;

        public RatingsController(MovieContext pContext)
        {
            _context = pContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View(new Rating());
        }

        [HttpPost]
        public IActionResult Create(Rating pRating)
        {
            _context.Ratings.Update(pRating);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int pId)
        {
            var rating = _context.Ratings.Where(r => r.RatingID == pId).SingleOrDefault();
            return View(rating);
        }

        [HttpPost]
        public IActionResult Delete(Rating pRating)
        {
            _context.Ratings.Remove(pRating);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int pId)
        {
            var rating = _context.Ratings.Where(r => r.RatingID == pId).SingleOrDefault();
            return View(rating);
        }

        [HttpPost]
        public IActionResult Edit(Rating pRating)
        {
            _context.Ratings.Update(pRating);
            _context.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult List()
        {
            var ratings = _context.Ratings.OrderBy(r => r.Code).ToList();
            return View(ratings);
        }
    }
}