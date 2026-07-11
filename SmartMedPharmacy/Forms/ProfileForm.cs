using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using SmartMedPharmacy.Models;

namespace SmartMedPharmacy
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }


        private void LoadProfile()
        {
            Customer customer = new Customer();

            DataTable dt =
                customer.GetCustomerProfile(
                    Session.CustomerID);

            if (dt.Rows.Count > 0)
            {
                txtName.Text =
                    dt.Rows[0]["Name"].ToString();

                txtEmail.Text =
                    dt.Rows[0]["Email"].ToString();

                txtPhone.Text =
                    dt.Rows[0]["Phone"].ToString();

                txtAddress.Text =
                    dt.Rows[0]["Address"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();

                customer.UpdateProfile(
                    Session.CustomerID,
                    txtName.Text,
                    txtEmail.Text,
                    txtPhone.Text,
                    txtAddress.Text
                );

                MessageBox.Show("Profile Updated Successfully");

                LoadProfile(); // refresh form data
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.ShowDialog();
            this.Close();
        }
    }
}
