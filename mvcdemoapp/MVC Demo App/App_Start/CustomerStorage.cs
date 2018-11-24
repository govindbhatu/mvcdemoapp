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
            new Customer{Id=1,Name="Valda Snow"},
            new Customer{Id=2,Name="Collette Buie"},
            new Customer{Id=3,Name="Kisha Strecker"},
            new Customer{Id=4,Name="Lakeesha Linneman"},
            new Customer{Id=5,Name="Irene Cisco"},
            new Customer{Id=6,Name="Pearlie Spargo"},
            new Customer{Id=7,Name="Garland Cipriano"},
            new Customer{Id=8,Name="Myrl Tellez"},
            new Customer{Id=9,Name="Dorothy Goggins"},
            new Customer{Id=10,Name="Many Flor"}
        };
    }
}