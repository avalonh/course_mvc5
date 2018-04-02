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
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            //var cus = GetCustomer();

            var cus = _context.Customers.Include(c => c.MembershipType).ToList();
            

            return View(cus);
        }

        public ActionResult Details(int id)
        {
            //var cus = GetCustomer().SingleOrDefault(s => s.Id == id);
            var cus = _context.Customers.SingleOrDefault(s => s.Id == id);

            if (cus == null)
                return HttpNotFound();

            return View(cus);
        }

        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = "Mary Williams"}

            };
        }

    }
}