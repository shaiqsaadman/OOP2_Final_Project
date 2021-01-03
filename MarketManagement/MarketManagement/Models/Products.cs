using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Models
{
    public class Products
    {
        SqlConnection conn;

        public Products()
        {

        }

        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddProduct(Product product)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Products VALUES('{0}','{1}')", product.Name, product.Type);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public Product GetProduct(string name)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Products WHERE name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product product = null;
            while (reader.Read())
            {
                product = new Product();
                product.Name = reader.GetString(reader.GetOrdinal("Name"));
                product.Type = reader.GetString(reader.GetOrdinal("Type"));

            }
            conn.Close();
            return product;
        }

        public bool UpdateProduct(Product product)
        {

            conn.Open();
            string query = string.Format("UPDATE Products SET Name='{0}' WHERE Type='{1}'", product.Name, product.Type);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public bool DeleteProduct(string name)
        {

            conn.Open();
            string query = string.Format("delete from Products where name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

    }
}
