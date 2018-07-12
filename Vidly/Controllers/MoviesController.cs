using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie {Name = "Shrek", Id = 1},
            new Movie {Name = "Wall-e", Id = 2}
        };

        private static List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "John Smith", Id = 1},
            new Customer { Name = "Mary Williams", Id = 2}
        };

        private RandomMovieViewModel viewModel = new RandomMovieViewModel
        {
            Movies = movies,
            Customers = customers
        };

        // GET: Movies/Random
        public ActionResult Random()
        {
            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("Movies")]
        public ActionResult Index()
        {
            return View(viewModel);
        }

        [Route("Movies/Details/{Id}")]
        public ActionResult Details(int Id)
        {
            Movie movieFound = viewModel.Movies.Find(x => x.Id == Id);
            if (movieFound != null)
            {
                return View(movieFound);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}