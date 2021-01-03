using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement.Models
{
    public class Admins
    {
        SqlConnection conn;

        public Admins()
        {

        }

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddAdmin(Admin admin)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Admins VALUES('{0}','{1}','{2}')",admin.Name, admin.Username, admin.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public Admin AuthenticateAdmin(string username, string password)
        {
            conn.Open();
            string query = String.Format("Select * from Admins where Username='{0}'and Password='{1}'",username,password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            Admin admin = null;
            while(reader.Read())
            {
                admin = new Admin();
                admin.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.Username = reader.GetString(reader.GetOrdinal("Username"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return admin;
        }

        public bool UpdateAdmin(Admin admin)
        {

            conn.Open();
            string query = string.Format("update Admins set Name='{0}' where Username='{1}'",admin.Name, admin.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }

        public bool DeleteAdmin(Admin admin)
        {

            conn.Open();
            string query = string.Format("delete from Admins where Username='{0}'", admin.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            return false;
        }



    }
}
