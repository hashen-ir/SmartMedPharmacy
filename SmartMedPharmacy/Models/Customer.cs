using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using System.Data;

namespace SmartMedPharmacy.Models
{
    public class Customer : User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public DataTable GetCustomers()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                string query = "SELECT * FROM Customer";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }


        public void RegisterCustomer(
               string name,
               string email,
               string phone,
               string address,
               string username,
               string password)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO Customer
        (Name, Email, Phone, Address, Username, Password)
        VALUES
        (@Name, @Email, @Phone, @Address, @Username, @Password)";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetCustomer()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                string query =
                    "SELECT * FROM Customer";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public void UpdateCustomer( // For Admin to update any customer
           int customerId,
           string name,
           string email,
           string phone,
           string address)
    
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"UPDATE Customer SET Name = @Name,Email = @Email,Phone = @Phone,Address = @Address WHERE CustomerID = @CustomerID";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Updated Successfully");
                else
                    MessageBox.Show("Update Failed - No record found");
            }
        }
        public void UpdateProfile(int id, string name, string email, string phone, string address)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"UPDATE Customer SET Name = @Name,Email = @Email,Phone = @Phone,Address = @Address WHERE CustomerID = @ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCustomer(int customerId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query =
                    "DELETE FROM Customer WHERE CustomerID = @CustomerID";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@CustomerID",
                    customerId);

                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetCustomerProfile(int customerId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                string query =
                @"SELECT
            Name,
            Email,
            Phone,
            Address
          FROM Customer
          WHERE CustomerID = @CustomerID";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@CustomerID",
                    customerId);

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable GetMyOrders(int customerId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                string query =
                    "SELECT * FROM Orders WHERE CustomerID=@CustomerID";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@CustomerID",
                    customerId);

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public int GetCartCount(int customerId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query =
                    "SELECT COUNT(*) FROM Cart WHERE CustomerID=@CustomerID";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public void ClearCart(int customerId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = "DELETE FROM Cart WHERE CustomerID=@CustomerID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                cmd.ExecuteNonQuery();
            }
        }
        public void AddToCart(int customerId, int medicineId, int quantity)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                // Check expiry date
                string expiryQuery = @"SELECT ExpiryDate FROM Medicine WHERE MedicineID = @MedicineID";

                SqlCommand expiryCmd = new SqlCommand(expiryQuery, con);
                expiryCmd.Parameters.AddWithValue("@MedicineID", medicineId);

                object result = expiryCmd.ExecuteScalar();

                if (result == null)
                {
                    throw new Exception("Medicine not found.");
                }

                DateTime expiryDate = Convert.ToDateTime(result);

                if (expiryDate.Date <= DateTime.Today)
                {
                    throw new Exception("This medicine has expired and cannot be added to the cart.");
                }

                // Add medicine to cart
                string query = @"INSERT INTO Cart(CustomerID, MedicineID, Quantity) VALUES (@CustomerID, @MedicineID, @Quantity)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@MedicineID", medicineId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);

                string stockQuery = @"SELECT Stock FROM Medicine WHERE MedicineID = @MedicineID";

                SqlCommand stockCmd = new SqlCommand(stockQuery, con);
                stockCmd.Parameters.AddWithValue("@MedicineID", medicineId);

                int stock = Convert.ToInt32(stockCmd.ExecuteScalar());

                if (stock < quantity)
                {
                    throw new Exception("Not enough stock available.");
                }

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetCartItems(int customerId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT C.CartID,C.MedicineID,M.Name,C.Quantity,M.FinalPrice,(C.Quantity * M.FinalPrice) AS Total FROM Cart C
                INNER JOIN Medicine M ON C.MedicineID = M.MedicineID WHERE C.CustomerID = @CustomerID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public decimal GetCartTotal(int customerId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
SELECT ISNULL(SUM(C.Quantity * M.FinalPrice),0)
FROM Cart C
INNER JOIN Medicine M ON C.MedicineID = M.MedicineID
WHERE C.CustomerID=@CustomerID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                object result = cmd.ExecuteScalar();

                return Convert.ToDecimal(result);
            }
        }

        public DataTable FilterOrdersByStatus(int customerId, string status)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query;

                if (status == "All")
                {
                    query = @"SELECT OrderID,
                             OrderDate,
                             TotalAmount,
                             Status
                      FROM Orders
                      WHERE CustomerID=@CustomerID";
                }
                else
                {
                    query = @"SELECT OrderID,
                             OrderDate,
                             TotalAmount,
                             Status
                      FROM Orders
                      WHERE CustomerID=@CustomerID
                      AND Status=@Status";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                if (status != "All")
                    cmd.Parameters.AddWithValue("@Status", status);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable GetInvoice(int orderId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        SELECT
            O.OrderID,
            O.OrderDate,
            C.FullName,
            M.Name,
            OD.Quantity,
            OD.Price,
            (OD.Quantity*OD.Price) AS Total
        FROM Orders O
        INNER JOIN Customer C
            ON O.CustomerID=C.CustomerID
        INNER JOIN OrderDetails OD
            ON O.OrderID=OD.OrderID
        INNER JOIN Medicine M
            ON OD.MedicineID=M.MedicineID
        WHERE O.OrderID=@OrderID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@OrderID", orderId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }

}
