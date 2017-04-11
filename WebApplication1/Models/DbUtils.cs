using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class DbUtils
    {
        static List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, CompanyName = "Academy" },
            new Customer { Id = 2, CompanyName = "Academic Work" },
            new Customer { Id = 3, CompanyName = "Warm Kitten" },

        };

        public static Customer[] GetAllCustomers()
        {
            return customers.ToArray(); //Array istf List pga bara läsa, inte lägga till. En signal till den som ser koden
        }
    }
}
