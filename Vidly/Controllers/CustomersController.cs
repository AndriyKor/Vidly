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
        List<Customer> customers = new List<Customer>
        {
            new Customer { Name = "David de Gea", Id = 1 },
            new Customer { Name = "Mario Balotelli", Id = 2 }
        };

        // GET: Customers
        public ActionResult Index()
        {
            var customersViewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(customersViewModel);
        }

        public ActionResult Details(int Id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == Id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}