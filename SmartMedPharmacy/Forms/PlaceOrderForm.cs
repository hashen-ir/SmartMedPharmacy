using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartMedPharmacy.Models;
namespace SmartMedPharmacy
{
    public partial class PlaceOrderForm : Form
    {

        private string prescriptionPath = "";
        private int medicineId = 0;
        private decimal medicinePrice = 0;
        private decimal medicineFinalPrice;


        public PlaceOrderForm()
        {
            InitializeComponent();
        }

        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            LoadMedicines();
            LoadCartItems();
            LoadCart();

            
            medicinePrice = 0;
            medicineFinalPrice = 0;


        }

        private void LoadCart()
        {
            Customer customer = new Customer();
            dgvCart.DataSource =
                customer.GetCartItems(Session.CustomerID);
        }


        private void LoadCartItems()
        {
            Customer customer = new Customer();

            lblCartItems.Text =
                "Cart Items: " +
                customer.GetCartCount(Session.CustomerID);
        }
        private void btnUploadPrescription_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Prescription";

            ofd.Filter =
                "Image Files (*.jpg;*.png)|*.jpg;*.png|PDF Files (*.pdf)|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Order order = new Order();

                prescriptionPath =
                    order.GetPrescriptionPath(ofd.FileName);

                lblPrescription.Text =
                    order.GetPrescriptionFileName(prescriptionPath);

                MessageBox.Show(
                    "Prescription Uploaded Successfully");
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();

                // 1. Check cart is empty
                if (customer.GetCartCount(Session.CustomerID) == 0)
                {
                    MessageBox.Show("Your cart is empty. Please add medicines first.");
                    return;
                }

                // 2. Get cart items
                var cartItems = customer.GetCartItems(Session.CustomerID);

                if (cartItems == null || cartItems.Rows.Count == 0)
                {
                    MessageBox.Show("Cart data not found.");
                    return;
                }

                Order order = new Order();

                
                foreach (DataRow item in cartItems.Rows)
                {
                    order.PlaceOrder(
                        Session.CustomerID,
                        Convert.ToInt32(item["MedicineID"]),
                        Convert.ToInt32(item["Quantity"]),
                        Convert.ToDecimal(item["FinalPrice"])
                    );
                }

                
                customer.ClearCart(Session.CustomerID);

                MessageBox.Show("Order Placed Successfully");
                LoadCart(); 
                LoadCartItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvMedicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow row = dgvMedicines.Rows[e.RowIndex];

                medicineId = Convert.ToInt32(row.Cells["MedicineID"].Value);
                medicinePrice = Convert.ToDecimal(row.Cells["FinalPrice"].Value);
                medicineFinalPrice = medicinePrice;

                MessageBox.Show("Selected Medicine ID: " + medicineId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting medicine: " + ex.Message);
            }
        }

        private void dgvMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }


        private void LoadMedicines() // Load medicines into the DataGridView
        {
            dgvMedicines.AutoGenerateColumns = true;
            dgvMedicines.DataSource = new Medicine().GetMedicinesForOrder();
            HighlightExpiredMedicines();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.ShowDialog();
            this.Close();
        }

        private void lblPrescription_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMedicines.CurrentRow == null)
                {
                    MessageBox.Show("Select a medicine first.");
                    return;
                }

                int medicineId = Convert.ToInt32(dgvMedicines.CurrentRow.Cells["MedicineID"].Value);

                int quantity = (int)numQuantity.Value;

                if (medicineId <= 0)
                {
                    MessageBox.Show("Invalid medicine selected.");
                    return;
                }

                Customer customer = new Customer();
                customer.AddToCart(Session.CustomerID, medicineId, quantity);

                MessageBox.Show("Added to Cart");

                LoadCart();        
                LoadCartTotal();
                LoadCartItems();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result =
                    MessageBox.Show("Are you sure to clear cart?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Customer customer = new Customer();
                    customer.ClearCart(Session.CustomerID);

                    MessageBox.Show("Cart Cleared");

                    LoadCart(); 
                    LoadCartTotal(); LoadCartItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();

            dgvMedicines.DataSource =
                medicine.SearchMedicines(txtSearch.Text);
        }

        private void LoadCartTotal()
        {
            Customer customer = new Customer();

            decimal total = customer.GetCartTotal(Session.CustomerID);

            lblTotalAmount.Text = "Total : Rs. " + total.ToString("N2");
        }

        private void HighlightExpiredMedicines()
        {
            foreach (DataGridViewRow row in dgvMedicines.Rows)
            {
                if (row.IsNewRow) continue;

                DateTime expiryDate = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);

                if (expiryDate.Date <= DateTime.Today)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                    row.DefaultCellStyle.Font =
                        new Font(dgvMedicines.Font, FontStyle.Bold);
                }
            }
        }
    }
}
