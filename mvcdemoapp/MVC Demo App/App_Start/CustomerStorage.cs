using MVC_Demo_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Demo_App.App_Start
{
    public static class CustomerStorage
    {
        public static List<Customer> CustomersStore = new List<Customer>
        {
            new Customer{Id=1,Name="Customer 1"},
            new Customer{Id=2,Name="Customer 2"},
            new Customer{Id=3,Name="Customer 3"},
            new Customer{Id=4,Name="Customer 4"},
            new Customer{Id=5,Name="Customer 5"},
            new Customer{Id=6,Name="Customer 6"},
            new Customer{Id=7,Name="Customer 7"},
            new Customer{Id=8,Name="Customer 8"},
            new Customer{Id=9,Name="Customer 9"},
            new Customer{Id=10,Name="Customer 10"}
        };
    }
}