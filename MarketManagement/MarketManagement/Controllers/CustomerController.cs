using MarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Controllers
{
    public class CustomerController
    {
        static Database db = new Database();
        public static Customer AuthenticateCustomer(string username, string password)
        {
            return db.Customers.AuthenticateCustomer(username, password);
        }

        public static bool AddCustomer(dynamic customer)
        {

            Customer e = new Customer();
            e.Name = customer.Name;
            e.Username = customer.Username;
            e.Password = customer.Password;
            return db.Customers.AddCustomer(e);

        }

        public static Customer GetCustomer(string username)
        {
            return db.Customers.GetCustomer(username);

        }

        public static bool UpdateCustomer(dynamic customer)
        {
            Customer e = new Customer();
            e.Username = customer.Username;
            e.Name = customer.Name;
            return db.Customers.UpdateCustomer(e);
        }

        public static bool DeleteCustomer(string username)
        {
            return db.Customers.DeleteCustomer(username);
        }

    }
}
