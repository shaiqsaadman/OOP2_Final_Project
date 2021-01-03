using MarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Controllers
{
    public class ShopController
    {

        static Database db = new Database();
        

        public static bool AddShop(dynamic shop)
        {

            Shop s = new Shop();
            s.Name = shop.Name;
            s.Type = shop.Type;
            return db.Shops.AddShop(s);

        }

        public static Shop GetShop(string name)
        {
            return db.Shops.GetShop(name);

        }

        public static bool UpdateShop(dynamic shop)
        {
            Shop s = new Shop();
            s.Name = shop.Name;
            s.Type = shop.Type;
            return db.Shops.UpdateShop(s);
        }

        public static bool DeleteShop(string name)
        {
            return db.Shops.DeleteShop(name);
        }

    }
}
