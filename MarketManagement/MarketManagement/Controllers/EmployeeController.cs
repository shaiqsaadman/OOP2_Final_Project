using MarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Controllers
{
    public class EmployeeController
    {

        static Database db = new Database();
        public static Employee AuthenticateEmployee(string username, string password)
        {
            return db.Employees.AuthenticateEmployee(username, password);
        }

        public static bool AddEmployee(dynamic employee)
        {

            Employee e = new Employee();
            e.Name = employee.Name;
            e.Username = employee.Username;
            e.Password = employee.Password;
            return  db.Employees.AddEmployee(e);

        }

        public static Employee GetEmployee(string username)
        {
            return db.Employees.GetEmployee(username);
            
        }

        public static bool UpdateEmployee(dynamic employee)
        {
            Employee e = new Employee();
            e.Username = employee.Username;
            e.Name = employee.Name;
            return db.Employees.UpdateEmployee(e);
        }

        public static bool DeleteEmployee(string username)
        {
            return db.Employees.DeleteEmployee(username);
        }

    }
}
