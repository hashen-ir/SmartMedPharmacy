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
    public partial class CustomerForm : Form
    {
        private int customerId = 0;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            Customer customer =
         new Customer();

            dgvCustomers.DataSource =
                customer.GetCustomer();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvCustomers.Rows[e.RowIndex];

                txtCustomerID.Text =
                    row.Cells["CustomerID"].Value.ToString();

                txtName.Text =
                    row.Cells["Name"].Value.ToString();

                txtEmail.Text =
                    row.Cells["Email"].Value.ToString();

                txtPhone.Text =
                    row.Cells["Phone"].Value.ToString();

                txtAddress.Text =
                    row.Cells["Address"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerID.Text))
                {
                    MessageBox.Show("Please select a customer first!");
                    return;
                }

                Customer customer = new Customer();

                customer.UpdateCustomer(
                    Convert.ToInt32(txtCustomerID.Text),
                    txtName.Text,
                    txtEmail.Text,
                    txtPhone.Text,
                    txtAddress.Text
                );
                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.DeleteCustomer(customerId);
            MessageBox.Show(
                "Customer Deleted Successfully!");
            LoadCustomers();

        }
    }
}
