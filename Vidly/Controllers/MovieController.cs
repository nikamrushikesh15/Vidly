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

        public ActionResult New()
        {

            var genr = _context.genre.ToList();
            var viewmodel = new NewMovieClass
            {

                genrs = genr
            };
            return View(viewmodel);
        }
        [HttpPost]
        public ActionResult create(Movie movie) {
            try { 
            if (movie.Id == 0)
            {
                movie.Date_Added = DateTime.Now;
                _context.Movie.Add(movie);


            }
            else
            {
                var movieIdDb = _context.Movie.Single(c => c.Id == movie.Id);
                movieIdDb.name = movie.name;
                movieIdDb.Date_Added = movie.Date_Added;
                movieIdDb.stock = movie.stock;


                movieIdDb.GenrId = movie.GenrId;


            }
            
            
                _context.SaveChanges();
            }
            catch (NullReferenceException e)
            {


            }
            return RedirectToAction("Index", "Movie");
                //  return View();
           

        }
        public ActionResult Edit(int id)
        {
            var Movie = _context.Movie.SingleOrDefault(c => c.Id == id);
            if (Movie == null)
                return HttpNotFound();
            var viewmodel = new NewMovieClass()
            {
                Movie = Movie,
                genrs = _context.genre.ToList()



            };
            return View("New", viewmodel);
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