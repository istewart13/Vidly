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
        private ApplicationDbContext _context;
        private List<Customer> customers = new List<Customer> {
            new Customer { Name = "John Smith", Id = 1},
            new Customer { Name = "Mary Williams", Id = 2}
        };

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Customers")]
        public ActionResult Index()
        {
            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("Customers/Details/{Id}")]
        public ActionResult Details(int Id)
        {
            Customer customerFound = customers.Find(x => x.Id == Id);
            if (customerFound != null)
            {
                return View(customerFound);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}