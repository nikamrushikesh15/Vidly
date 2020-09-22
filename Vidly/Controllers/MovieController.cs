using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private ApplicationDbContext _context;
        public MovieController()
        {

            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    //Dispose(disposing);
        }
        public ActionResult Index()
        {
            var Movies = _context.Movie.ToList();

            return View(Movies);
        }

        public ActionResult Detail(int id)
        {
            var movie = _context.Movie.ToList().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, name = "raaj" },
                new Movie { Id = 2, name = "ek thi dyane" }
            };
        }
    }
}