using MVC_Demo_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo_App.App_Start
{
    public static class MovieStorage
    {
        public static List<Movie> MovieStore = new List<Movie>
        {
            new Movie{Id=1,Name="Project X"},
            new Movie{Id=2,Name="The Warriors"},
            new Movie{Id=3,Name="Role Models"},
            new Movie{Id=4,Name="The Hobbit"},
            new Movie{Id=5,Name="Get Rich or Die Tryin"},
            new Movie{Id=6,Name="Blow"},
            new Movie{Id=7,Name="Limitless"},
            new Movie{Id=8,Name="Grown Ups"},
            new Movie{Id=9,Name="Oblivion"},
            new Movie{Id=10,Name="Jack Reacher"}
        };
    }
}