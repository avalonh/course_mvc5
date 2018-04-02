using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

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

        // GET: Movies
        public ActionResult Index()
        {
            return View(_context.Movies.Include(m => m.Genre).ToList());
        }

        public ActionResult Details(int id)
        {
            var mov = _context.Movies
                .Include(m => m.Genre)
                .SingleOrDefault(s => s.Id == id);

            if (mov == null)
            {
                return HttpNotFound();
            }

            return View(mov);
        }






        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie {Name = "Shrek !"};

            var customers = new List<Customer>
            {
                new Customer {Name = "cus 01"},
                new Customer {Name = "cus 02"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);

            //return View(model:);


            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            
            //return Content("hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {IViewPageActivator = 1});
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult test(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));


        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek"},
                new Movie {Id = 2, Name = "Day after tomorow"}
            };
        }
    }
}