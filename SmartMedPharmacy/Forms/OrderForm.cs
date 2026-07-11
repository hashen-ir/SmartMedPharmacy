using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartMedPharmacy
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            Admin admin = new Admin();

            dgvOrders.DataSource = admin.GetAllOrders();
        }


        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOrderId.Text))
                {
                    MessageBox.Show("Please select an order.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmbStatus.Text))
                {
                    MessageBox.Show("Please select a status.");
                    return;
                }

                Admin admin = new Admin();

                admin.UpdateOrderStatus(
                    Convert.ToInt32(txtOrderId.Text),
                    cmbStatus.Text);

                MessageBox.Show("Order Status Updated Successfully");

                LoadOrders();

                txtOrderId.Clear();
                cmbStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrders.Rows[e.RowIndex];

                cmbStatus.Text =
                    row.Cells["Status"].Value.ToString();

                txtOrderId.Text =
                    row.Cells["OrderID"].Value.ToString();


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {
            if (txtOrderId.Text == "")
            {
                LoadOrders();
                return;
            }

            try
            {
                Admin admin = new Admin();

                dgvOrders.DataSource =
                    admin.SearchOrderById(
                        Convert.ToInt32(txtOrderId.Text));
            }
            catch
            {
                //
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
