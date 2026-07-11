using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class TrackOrdersForm : Form
    {
        public TrackOrdersForm()
        {
            InitializeComponent();
        }

        private void TrackOrdersForm_Load(object sender, EventArgs e)
        {

            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Ready for Pickup");
            cmbStatus.Items.Add("Delivered");

            cmbStatus.SelectedIndex = 0;
            Customer customer = new Customer();

            dgvOrders.DataSource =
                customer.GetMyOrders(Session.CustomerID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.ShowDialog();
            this.Close();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            dgvOrders.DataSource =
                customer.FilterOrdersByStatus(
                    Session.CustomerID,
                    cmbStatus.Text);
        }
    }
}
