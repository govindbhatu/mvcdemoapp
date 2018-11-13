using MVC_Demo_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo_App.ViewModel;

namespace MVC_Demo_App.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer{ Name="Customer 1"},
                new Customer{ Name="Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Detail(int Id)
        {
            var customer = new Customer
            {
                Name = "Detail of customer"
            };
            return View(customer);
        }
    }
}