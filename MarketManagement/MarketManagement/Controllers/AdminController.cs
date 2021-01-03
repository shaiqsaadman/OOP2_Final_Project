using MarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Controllers
{
    public class AdminController
    {

        static Database db = new Database();
        public static Admin AuthenticateAdmin(string username, string password)
        {
            return db.Admins.AuthenticateAdmin(username, password);
        }

        public static bool AddAdmin(dynamic admin)
        {

            Admin a = new Admin();
            a.Name = admin.Name;
            a.Username = admin.Username;
            a.Password = admin.Password;
            return db.Admins.AddAdmin(a);

        }

    }
}
