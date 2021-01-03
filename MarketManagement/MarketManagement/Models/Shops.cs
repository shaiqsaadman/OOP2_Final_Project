using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Models
{
    public class Shops
    {

        SqlConnection conn;

        public Shops()
        {

        }

        public Shops(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddShop(Shop shop)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Shops VALUES('{0}','{1}')", shop.Name, shop.Type);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public Shop GetShop(string name)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Shops WHERE name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Shop shop = null;
            while (reader.Read())
            {
                shop = new Shop();
                shop.Name = reader.GetString(reader.GetOrdinal("Name"));
                shop.Type = reader.GetString(reader.GetOrdinal("Type"));
                
            }
            conn.Close();
            return shop;
        }

        public bool UpdateShop(Shop shop)
        {

            conn.Open();
            string query = string.Format("UPDATE Shops SET Name='{0}' WHERE Type='{1}'", shop.Name, shop.Type);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public bool DeleteShop(string name)
        {

            conn.Open();
            string query = string.Format("delete from Shops where name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

    }
}
