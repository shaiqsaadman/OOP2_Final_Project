using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Models
{
    class Database
    {
        public Admins Admins { get; set; }
        public Employees Employees { get; set; }
        public Customers Customers { get; set; }
        public Shops Shops { get; set; }
        public Products Products { get; set; }

        public Database()
        {
            string connString = @"Server=DESKTOP-9GTJ8MC\SQLEXPRESS; Database=MarketManagement; Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Admins = new Admins(conn);
            Employees = new Employees(conn);
            Customers = new Customers(conn);
            Shops = new Shops(conn);
            Products = new Products(conn);
        }
    }
}
