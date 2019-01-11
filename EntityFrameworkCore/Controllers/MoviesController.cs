using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityFrameworkCore.Data;
using EntityFrameworkCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EntityFrameworkCore.Controllers
{
    public class MoviesController : Controller
    {
        private MovieContext _context;

        public MoviesController(MovieContext pContext)
        {
            _context = pContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Ratings"] = new SelectList( _context.Ratings.OrderBy(r => r.Code).ToList(), "RatingID", "Name");
            return View(new Movie());
        }

        [HttpPost]
        public IActionResult Create(Movie pMovie)
        {
            int rv;
            _context.Movies.Update(pMovie);
            rv = _context.SaveChanges();

            if (rv == 1)
                return RedirectToAction("List");
            else
                return RedirectToAction("List");
        }

        public IActionResult Detail(int pId)
        {
            var movie = _context.Movies.Where(m => m.MovieID == pId).SingleOrDefault();
            return View(movie);
        }

        //public IActionResult List()
        //{
        //    var movies = _context.Movies.OrderBy(m => m.Title);

        //    //ViewData["Movies"] = movies.ToList();
        //    //return View();

        //    return View(movies.ToList());

        //}

        public IActionResult List(int? pRatingId)
        {
            vmListMovies listMovies = new vmListMovies();
            ICollection<Movie> movies = _context.Movies.OrderBy(m => m.Title).ToList();

            if (pRatingId != null && pRatingId > 0)
            {
                movies = movies.Where(m => m.RatingID == pRatingId).ToList();
            }

            listMovies.Movies = movies;
            listMovies.Ratings = new SelectList(_context.Ratings.OrderBy(r => r.RatingID), "RatingID", "Name");
            listMovies.RatingId = (pRatingId == null ? 0 : pRatingId);

            return View(listMovies);
        }
    }
}
