using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Movies")]
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        [Route("Movies/Details/{Id}")]
        public ActionResult Details(int Id)
        {
            var movies = _context.Movies.ToList();
            Movie movieFound = movies.Find(x => x.Id == Id);
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