using MVC_Demo_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo_App.ViewModel;
using MVC_Demo_App.App_Start;

namespace MVC_Demo_App.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new RandomMovieViewModel
            {
                Customers = CustomerStorage.CustomersStore
            };
            return View(viewModel);
        }
        public ActionResult Detail(int Id)
        {
            var customer = CustomerStorage.CustomersStore.Where(item => item.Id == Id).FirstOrDefault();
            return View(customer);
        }
    }
}