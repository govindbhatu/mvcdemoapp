using MVC_Demo_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo_App.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}