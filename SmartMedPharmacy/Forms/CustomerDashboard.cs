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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.Username;
            /*MessageBox.Show("Customer ID: " + Session.CustomerID);*/
        }

        private void btnPlaceOrders_Click(object sender, EventArgs e)
        {
            PlaceOrderForm frm = new PlaceOrderForm();
            frm.Show();
            this.Hide();

        }

        private void btnTrackOrders_Click(object sender, EventArgs e)
        {
            TrackOrdersForm form = new TrackOrdersForm();
            form.Show();
            this.Hide();
        }

        private void btnSearchMedicines_Click(object sender, EventArgs e)
        {
            SearchMedicineForm frm = new SearchMedicineForm();
            this.Hide();
            frm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm frm = new ProfileForm();
            this.Hide();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
