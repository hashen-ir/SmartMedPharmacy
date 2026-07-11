using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using System.IO;

namespace SmartMedPharmacy.Models
{
    internal class Order
    {
        public string GetPrescriptionPath(string filePath)
        {
            return filePath;
        }

        public string GetPrescriptionFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }
        public void PlaceOrder(
            int customerId,
            int medicineId,
            int qty,
            decimal unitPrice)
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                SqlTransaction transaction =
                    con.BeginTransaction();

                try
                {
                    decimal total =
                        unitPrice * qty;

                    string orderQuery =
                    @"INSERT INTO Orders
                    (CustomerID,OrderDate,TotalAmount,Status)

                    OUTPUT INSERTED.OrderID

                    VALUES
                    (@CustomerID,GETDATE(),@Total,'Pending')";

                    SqlCommand orderCmd =
                        new SqlCommand(
                            orderQuery,
                            con,
                            transaction);

                    orderCmd.Parameters.AddWithValue(
                        "@CustomerID",
                        customerId);

                    orderCmd.Parameters.AddWithValue(
                        "@Total",
                        total);

                    int orderId =
                        (int)orderCmd.ExecuteScalar();

                    string detailQuery =
                    @"INSERT INTO OrderDetails
                    (OrderID,MedicineID,Quantity,UnitPrice)
                    VALUES
                    (@OrderID,@MedicineID,@Quantity,@UnitPrice)";

                    SqlCommand detailCmd =
                        new SqlCommand(
                            detailQuery,
                            con,
                            transaction);

                    detailCmd.Parameters.AddWithValue(
                        "@OrderID",
                        orderId);

                    detailCmd.Parameters.AddWithValue(
                        "@MedicineID",
                        medicineId);

                    detailCmd.Parameters.AddWithValue(
                        "@Quantity",
                        qty);

                    detailCmd.Parameters.AddWithValue(
                        "@UnitPrice",
                        unitPrice);

                    detailCmd.ExecuteNonQuery();

                    string stockQuery =
                    @"UPDATE Medicine
                      SET Stock = Stock - @Qty
                      WHERE MedicineID = @MedicineID";

                    SqlCommand stockCmd =
                        new SqlCommand(
                            stockQuery,
                            con,
                            transaction);

                    stockCmd.Parameters.AddWithValue(
                        "@Qty",
                        qty);

                    stockCmd.Parameters.AddWithValue(
                        "@MedicineID",
                        medicineId);

                    stockCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }


    }
}