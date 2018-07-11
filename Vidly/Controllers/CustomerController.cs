using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        [Route("Customers")]
        public ActionResult Index()
        {
            var customers = new List<Customer> {
                new Customer { Name = "John Smith" },
                new Customer { Name = "Mary Williams" }
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}