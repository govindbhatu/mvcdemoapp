using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo_App.App_Start;
using MVC_Demo_App.Models;
using MVC_Demo_App.ViewModel;

namespace MVC_Demo_App.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var viewModel = new RandomMovieViewModel
            {
                Movie = MovieStorage.MovieStore.First(),
                Customers = CustomerStorage.CustomersStore
            };
            return View(viewModel);
        }
    }
}