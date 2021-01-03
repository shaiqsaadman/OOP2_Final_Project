using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Models
{
    public class Customers
    {

        SqlConnection conn;

        public Customers()
        {

        }

        public Customers(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddCustomer(Customer customer)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Customers VALUES('{0}','{1}','{2}')", customer.Name, customer.Username, customer.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public Customer AuthenticateCustomer(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Customers WHERE Username='{0}' AND Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.Username = reader.GetString(reader.GetOrdinal("Username"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return customer;
        }

        public Customer GetCustomer(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Customers WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                customer.Name = reader.GetString(reader.GetOrdinal("Name"));
                customer.Username = reader.GetString(reader.GetOrdinal("Username"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return customer;
        }

        public bool UpdateCustomer(Customer customer)
        {

            conn.Open();
            string query = string.Format("update Customers set Name='{0}' where Username='{1}'", customer.Name, customer.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public bool DeleteCustomer(string username)
        {

            conn.Open();
            string query = string.Format("delete from Customers where Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

    }
}
