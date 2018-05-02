using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ValueObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var _db = new Context();
            var customer = _db.Customer.ToList();

            customer.ForEach(p => Console.Write($"{p.Name.FirstName} {p.Name.LastName} {p.EmailAddress.Email } \n"));
            
        }
    }
}
