using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMedPharmacy.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public bool Login(string username, string password)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT CustomerID, Username FROM Customer WHERE Username=@Username AND Password=@Password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Session.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                    Session.Username = reader["Username"].ToString();
                    Session.Role = "Customer";

                    MessageBox.Show("Login success! customer ID: " + Session.CustomerID);

                    return true;
                }
            }

            return false;
        }
    }
}

