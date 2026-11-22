using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SmartMedPharmacy.Models
{
    public class Medicine
    {
        public int MedicineID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public DataTable GetMedicines() 
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                SELECT
                    MedicineID,
                    Name,
                    Category,
                    Stock,
                    Dosage,
                    Supplier,
                    Price,
                    Discount,
                    FinalPrice,
                    ExpiryDate
                FROM Medicine";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable GetMediciness() 
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"
                SELECT
                    MedicineID,
                    Name,
                    Category,
                    Stock,
                    Dosage,
                    Price,
                    Discount,
                    FinalPrice,
                    ExpiryDate
                FROM Medicine";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public void AddMedicine( 
                string name,
                string category,
                string dosage,
                string supplier,
                decimal price,
                DateTime expiryDate,
                int stock,
                decimal discount,
                decimal finalPrice)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"INSERT INTO Medicine(Name, Category, Dosage, Supplier, Price, Stock, Discount, FinalPrice, ExpiryDate) VALUES (@Name, @Category, @Dosage, @Supplier, @Price, @Stock, @Discount, @FinalPrice, @ExpiryDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Dosage", dosage);
                cmd.Parameters.AddWithValue("@Supplier", supplier);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@Discount", discount);
                cmd.Parameters.AddWithValue("@FinalPrice", finalPrice);
                cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMedicine(
               int medicineId,
               string name,
               string category,
               string dosage,
               string supplier,   
               decimal price,
               int stock,
               decimal discount,
               decimal finalPrice,
               DateTime expiryDate)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"UPDATE Medicine SET Name = @Name,Category = @Category,Dosage = @Dosage,Supplier = @Supplier,Price = @Price,Stock = @Stock,Discount = @Discount,FinalPrice = @FinalPrice,ExpiryDate = @ExpiryDate WHERE MedicineID = @MedicineID";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MedicineID", medicineId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Dosage", dosage);
                cmd.Parameters.AddWithValue("@Supplier", supplier);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@Discount", discount);
                cmd.Parameters.AddWithValue("@FinalPrice", finalPrice);
                cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMedicine(int medicineId)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query =
                    "DELETE FROM Medicine WHERE MedicineID = @MedicineID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@MedicineID", medicineId);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetMedicinesForOrder()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT MedicineID,Name,FinalPrice,ExpiryDate FROM Medicine";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
        public DataTable SearchMedicine(string keyword)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT MedicineID,Name,Category,Dosage,Price,Stock,ExpiryDate,Discount,FinalPrice FROM Medicine WHERE Name LIKE @Keyword";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable FilterByCategory(string category)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

               string query = @"SELECT MedicineID,Name,Category,Dosage,Price,Stock,ExpiryDate,Discount,FinalPrice FROM Medicine WHERE Category = @Category";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Category", category);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public DataTable FilterByPrice(decimal min, decimal max)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT MedicineID,Name,Category,Dosage,Price,Stock,ExpiryDate,Discount,FinalPrice FROM Medicine WHERE Price BETWEEN @Min AND @Max";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Min", min);
                cmd.Parameters.AddWithValue("@Max", max);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public DataTable SearchMedicines(string keyword)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"SELECT MedicineID,
                                Name,
                                Category,
                                FinalPrice,
                                Stock
                         FROM Medicine
                         WHERE Name LIKE @keyword";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public DataTable GetExpiredMedicines()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        SELECT MedicineID, Name, ExpiryDate
        FROM Medicine
        WHERE ExpiryDate <= GETDATE()";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public DataTable GetExpiringSoonMedicines()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                string query = @"
        SELECT Name, ExpiryDate
        FROM Medicine
        WHERE ExpiryDate > GETDATE()
        AND ExpiryDate <= DATEADD(DAY, 30, GETDATE())
        ORDER BY ExpiryDate";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }
    }
}


        
            
        
    



