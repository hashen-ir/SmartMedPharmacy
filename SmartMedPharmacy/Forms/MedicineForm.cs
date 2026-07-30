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
    public partial class MedicineForm : Form
    {
        private int medicineId = 0;
        public MedicineForm()
        {
            InitializeComponent();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            LoadMedicines();
            ClearFields();
        }

        private void CalculatePrice() // Calculate the final price based on the price and discount
        {
            decimal price;
            decimal discount;

            if (decimal.TryParse(txtPrice.Text, out price) &&
                decimal.TryParse(txtDiscount.Text, out discount))
            {
                decimal finalPrice =
                    price - (price * discount / 100);

                txtFinalPrice.Text =
                    finalPrice.ToString();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }


        private void LoadMedicines()
        {
            Medicine medicine = new Medicine();

            dgvMedicine.DataSource =
                medicine.GetMedicines();

            HighlightExpiredMedicines();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtCategory.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show(
                    "Please fill all required fields.");

                return;
            }
            Medicine medicine = new Medicine();

            medicine.AddMedicine(
                     txtName.Text,
                     txtCategory.Text,
                     txtDosage.Text,
                     txtSupplier.Text,
                     Convert.ToDecimal(txtPrice.Text),
                     dtpExpiry.Value,
                     Convert.ToInt32(txtStock.Text),
                     Convert.ToDecimal(txtDiscount.Text),
                     Convert.ToDecimal(txtFinalPrice.Text));

            MessageBox.Show(
                "Medicine Added Successfully!!!");

            LoadMedicines();
            ClearFields();
        }

        private void dgvMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvMedicine.Rows[e.RowIndex];

                medicineId =
                    Convert.ToInt32(row.Cells["MedicineID"].Value);

                txtName.Text =
                    row.Cells["Name"].Value.ToString();

                txtCategory.Text =
                    row.Cells["Category"].Value.ToString();

                txtDosage.Text =
                    row.Cells["Dosage"].Value.ToString();

                txtSupplier.Text =
                    row.Cells["Supplier"].Value.ToString();

                txtPrice.Text =
                    row.Cells["Price"].Value.ToString();

                txtStock.Text =
                    row.Cells["Stock"].Value.ToString();

                txtDiscount.Text =
                    row.Cells["Discount"].Value.ToString();

                txtFinalPrice.Text =
                    row.Cells["FinalPrice"].Value.ToString();

                dtpExpiry.Value =
                    Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();

            medicine.UpdateMedicine(
                     medicineId,
                     txtName.Text,
                     txtCategory.Text,
                     txtDosage.Text,
                     txtSupplier.Text,
                     Convert.ToDecimal(txtPrice.Text),
                     Convert.ToInt32(txtStock.Text),
                     Convert.ToDecimal(txtDiscount.Text),
                     Convert.ToDecimal(txtFinalPrice.Text),
                     dtpExpiry.Value);

            MessageBox.Show(
                "Medicine Updated Successfully!");

            LoadMedicines();

            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (medicineId <= 0)
            {
                MessageBox.Show("Please select a medicine first!");
                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this medicine?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Medicine medicine = new Medicine();

                medicine.DeleteMedicine(medicineId);

                MessageBox.Show("Medicine Deleted Successfully!");

                LoadMedicines();

                ClearFields();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Hide();
        }

        private void txtFinalPrice_TextChanged(object sender, EventArgs e)
        {

        }


        private void ClearFields()
        {
            txtName.Clear();
            txtCategory.Clear();
            txtDosage.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtDiscount.Clear();
            txtFinalPrice.Clear();
            txtSupplier.Clear();
            dtpExpiry.Value = DateTime.Now;
        }


        private void HighlightExpiredMedicines()
        {
            foreach (DataGridViewRow row in dgvMedicine.Rows)
            {
                if (row.IsNewRow) continue;

                DateTime expiryDate = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);

                if (expiryDate.Date <= DateTime.Today)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    row.DefaultCellStyle.Font =
                        new Font(dgvMedicine.Font, FontStyle.Bold);
                }
            }
        }
    }
}

