﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name="Mary Williams"}
            };
            return View(customers);
        }
    }
}