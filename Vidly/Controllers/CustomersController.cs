using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var cus = GetCustomer();
            //cus.Customers.Clear();

            return View(cus);
        }

        public ActionResult Details(int id)
        {
            var cus = GetCustomer().SingleOrDefault(s => s.Id == id);

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