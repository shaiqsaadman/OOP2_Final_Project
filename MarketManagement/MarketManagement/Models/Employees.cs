using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Models
{
    public class Employees
    {

        SqlConnection conn;

        public Employees()
        {

        }

        public Employees(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddEmployee(Employee employee)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Employees VALUES('{0}','{1}','{2}')", employee.Name, employee.Username, employee.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public Employee AuthenticateEmployee(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Employees WHERE Username='{0}' AND Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.Username = reader.GetString(reader.GetOrdinal("Username"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return employee;
        }

        public Employee GetEmployee(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Employees WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                employee.Name = reader.GetString(reader.GetOrdinal("Name"));
                employee.Username = reader.GetString(reader.GetOrdinal("Username"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return employee;
        }

        public bool UpdateEmployee(Employee employee)
        {

            conn.Open();
            string query = string.Format("update Employees set Name='{0}' where Username='{1}'", employee.Name, employee.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public bool DeleteEmployee(string username)
        {

            conn.Open();
            string query = string.Format("delete from Employees where Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

    }
}
