using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SmartMedPharmacy.Models
{
    public class Admin : User, IReport
    {
        private OrderForm orderForm;

        public bool LoginAdmin(string username, string password)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT AdminID, Username
                         FROM Admin
                         WHERE Username=@Username
                         AND Password=@Password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Session.AdminID = Convert.ToInt32(reader["AdminID"]);   // if you have AdminID
                    Session.Username = reader["Username"].ToString();
                    Session.Role = "Admin";

                    // Reset notification for this login session
                    Session.ExpiryNotificationShown = false;

                    return true;
                }
            }

            return false;
        }


        public void GenerateReport()
        {
            // will connect to Report.cs later
        }

        public DataTable GetSalesReport()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
        SELECT 
            O.OrderID,
            O.OrderDate,
            C.Name,
            O.TotalAmount,
            O.Status
        FROM Orders O
        INNER JOIN Customer C ON O.CustomerID = C.CustomerID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public DataTable GetStockReport()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
        SELECT 
            MedicineID,
            Name,
            Stock,
            Price,
            FinalPrice
        FROM Medicine";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }


        public DataTable GetCustomerOrderHistory(int customerId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        SELECT 
            O.OrderID,
            O.OrderDate,
            C.Name,
            O.TotalAmount,
            O.Status
        FROM Orders O
        INNER JOIN Customer C ON O.CustomerID = C.CustomerID
        WHERE O.CustomerID = @CustomerID
        ORDER BY O.OrderDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
        public DataTable GetAllCustomerOrderHistory()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        SELECT 
            O.OrderID,
            O.OrderDate,
            C.CustomerID,
            C.Name,
            O.TotalAmount,
            O.Status
        FROM Orders O
        INNER JOIN Customer C ON O.CustomerID = C.CustomerID
        ORDER BY O.OrderDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable GetAllOrders()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                string query = "SELECT * FROM Orders";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }


        public DataTable SearchOrderById(int orderId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query =
                    "SELECT * FROM Orders WHERE OrderID=@OrderID";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@OrderID", orderId);

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }


        public void UpdateOrderStatus(int orderId, string status)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        UPDATE Orders
        SET Status = @Status
        WHERE OrderID = @OrderID";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetSalesReports(DateTime fromDate, DateTime toDate)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        SELECT
            O.OrderID,
            C.Name,
            O.OrderDate,
            O.TotalAmount,
            O.Status
        FROM Orders O
        INNER JOIN Customer C
            ON O.CustomerID = C.CustomerID
        WHERE CAST(O.OrderDate AS DATE)
              BETWEEN @FromDate AND @ToDate
        ORDER BY O.OrderDate";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FromDate", fromDate.Date);
                cmd.Parameters.AddWithValue("@ToDate", toDate.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

       /* public DataTable GetOrdersByStatus(string status)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query;

                if (status == "All")
                {
                    query = @"
            SELECT
                OrderID,
                CustomerID,
                OrderDate,
                TotalAmount,
                Status
            FROM Orders";
                }
                else
                {
                    query = @"
            SELECT
                OrderID,
                CustomerID,
                OrderDate,
                TotalAmount,
                Status
            FROM Orders
            WHERE Status=@Status";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                if (status != "All")
                    cmd.Parameters.AddWithValue("@Status", status);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }*/
    }
}

