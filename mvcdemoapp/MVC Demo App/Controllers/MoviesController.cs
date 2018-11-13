using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo_App.Models;
using MVC_Demo_App.ViewModel;

namespace MVC_Demo_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer{Name="Customer 1"},
                new Customer{Name="Customer 2"},
                new Customer{Name="Customer 3"},
                new Customer{Name="Customer 4"},
                new Customer{Name="Customer 5"},
                new Customer{Name="Customer 6"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}