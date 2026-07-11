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
    public partial class SearchMedicineForm : Form
    {
        public SearchMedicineForm()
        {
            InitializeComponent();
        }

        private void SearchMedicineForm_Load(object sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            Medicine medicine = new Medicine();

            dgvMedicines.DataSource = medicine.GetMediciness();
        }


        private DataTable medicineTable;

        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Medicine medicine = new Medicine();

            dgvMedicines.DataSource =
                medicine.SearchMedicine(txtSearch.Text);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicine m = new Medicine();

            dgvMedicines.DataSource =
                m.FilterByCategory(cmbCategory.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            decimal min, max;

            if (!decimal.TryParse(txtMinPrice.Text, out min))
            {
                MessageBox.Show("Enter valid Min Price");
                return;
            }

            if (!decimal.TryParse(txtMaxPrice.Text, out max))
            {
                MessageBox.Show("Enter valid Max Price");
                return;
            }

            try
            {
                Medicine medicine = new Medicine();

                dgvMedicines.DataSource =
                    medicine.FilterByPrice(min, max);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.ShowDialog();
            this.Close();
        }
    }
}
