using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartMedPharmacy
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            if (!Session.ExpiryNotificationShown)
            {
                CheckExpiryMedicines();
                LoadExpiryInfo();

                Session.ExpiryNotificationShown = true;
            }
           /* CheckExpiry();*/
            LoadDashboard();
        }

        private void CheckExpiryMedicines()
        {
            Medicine medicine = new Medicine();

            DataTable dt = medicine.GetExpiredMedicines();

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(
                    "Expired Medicines Found: " + dt.Rows.Count,
                    "Expiry Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        /*private void CheckExpiry()
        {
            DBConnection db = new DBConnection();

            try
            {
                using (SqlConnection con = db.GetConnection())
                {
                    con.Open();

                    string query =
                        @"SELECT Name
                  FROM Medicine
                  WHERE ExpiryDate <= @Date";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue(
                        "@Date",
                        DateTime.Now.AddDays(30));

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string medicineName =
                            reader["Name"].ToString();

                        MessageBox.Show(
                        medicineName + " is expiring within 30 days!",
                            "Expiry Alert",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            MedicineForm frm = new MedicineForm();
            this.Hide();
            frm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderForm frm = new OrderForm();
            this.Hide();
            frm.ShowDialog();
        }

        private void LoadDashboard()
        {
            DBConnection db = new DBConnection();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                // Total Sales
                SqlCommand cmd1 = new SqlCommand(
                    "SELECT ISNULL(SUM(TotalAmount),0) FROM Orders",
                    con);

                lblTotalSales.Text = cmd1.ExecuteScalar().ToString();

                // Medicines Count
                SqlCommand cmd2 = new SqlCommand(
                    "SELECT COUNT(*) FROM Medicine",
                    con);

                lblMedicineStock.Text = cmd2.ExecuteScalar().ToString();

                // Active Orders
                SqlCommand cmd3 = new SqlCommand(
                    "SELECT COUNT(*) FROM Orders WHERE Status='Pending'",
                    con);

                lblActiveOrders.Text = cmd3.ExecuteScalar().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            this.Hide();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForm frm = new CustomerForm();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void LoadExpiryInfo()
        {
            Medicine medicine = new Medicine();

            DataTable expired = medicine.GetExpiredMedicines();
            DataTable expSoon = medicine.GetExpiringSoonMedicines();

            StringBuilder sb = new StringBuilder();

            // Expired Medicines
            sb.AppendLine("=== EXPIRED MEDICINES ===");

            if (expired.Rows.Count > 0)
            {
                foreach (DataRow row in expired.Rows)
                {
                    sb.AppendLine(
                        row["Name"].ToString() +
                        " - " +
                        Convert.ToDateTime(row["ExpiryDate"]).ToString("dd/MM/yyyy"));
                }
            }
            else
            {
                sb.AppendLine("No expired medicines.");
            }

            sb.AppendLine();
            sb.AppendLine("=== EXPIRING WITHIN 30 DAYS ===");

            // Expiring Soon Medicines
            if (expSoon.Rows.Count > 0)
            {
                foreach (DataRow row in expSoon.Rows)
                {
                    sb.AppendLine(
                        row["Name"].ToString() +
                        " - " +
                        Convert.ToDateTime(row["ExpiryDate"]).ToString("dd/MM/yyyy"));
                }
            }
            else
            {
                sb.AppendLine("No medicines expiring within 30 days.");
            }

            lblExpiryInfo.Text = sb.ToString();
        }
    }
}
