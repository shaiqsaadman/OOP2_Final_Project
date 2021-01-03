using MarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Controllers
{
    public class ProductController
    {

        static Database db = new Database();


        public static bool AddProduct(dynamic product)
        {

            Product p = new Product();
            p.Name = product.Name;
            p.Type = product.Type;
            return db.Products.AddProduct(p);

        }

        public static Product GetProduct(string name)
        {
            return db.Products.GetProduct(name);

        }

        public static bool UpdateProduct(dynamic product)
        {
            Product p = new Product();
            p.Name = product.Name;
            p.Type = product.Type;
            return db.Products.UpdateProduct(p);
        }

        public static bool DeleteProduct(string name)
        {
            return db.Products.DeleteProduct(name);
        }

    }
}
