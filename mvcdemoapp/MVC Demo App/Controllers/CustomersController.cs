using MVC_Demo_App.Models;
using System.Data.Entity;
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
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
            //var viewModel = new RandomMovieViewModel
            //{
            //    Customers = CustomerStorage.CustomersStore
            //};
            //return View(viewModel);
        }
        public ActionResult Detail(int Id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}