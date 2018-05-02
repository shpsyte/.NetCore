using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GlobalFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App Test, from Global Filters!");


            var _db = new MyContext();
            var customers = _db.Customer.ToList();

            foreach (var item in customers)
            {
                Console.Write($"Cliente { item.FirstName } \n");

            }

            Console.Write("No Filters \n");

            var allcustomer = _db.Customer.IgnoreQueryFilters();

            allcustomer.ForEachAsync(item => Console.Write($"Cliente { item.FirstName } \n"));
            
        }
    }
}
