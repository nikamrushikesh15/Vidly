using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies




        public ActionResult Random()
        {
            var movie = new Movie() { name = "john" };
            var customer = new List<Customer>
            {
                new Customer{ name="customer1"},
                new Customer { name="customer2"}

            };

            var viewmodel = new RandomMovieViewModel
            {
                movie = movie,
                customer = customer

            };

            return View(viewmodel);
        }
        public ActionResult Edit(int id)
        {

            return Content("id=" + id);
        }

        public ActionResult Index()
        {

            //    if (!pageindex.HasValue)
            //        pageindex = 1;

            //    if (string.IsNullOrEmpty(sortby)) {
            //        sortby = "name";
            //    }

            //    return Content(string.Format("pageinxed={0} & sortby={1}", pageindex, sortby));
            //}
            //[Route("Movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
            //public ActionResult ByReleasedate(int year,int month) {

            //    return Content("year"+year+"/"+month);

            //}


            var Movies = GetMovies();

            return View(Movies);

        }

        public ActionResult Detail(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

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