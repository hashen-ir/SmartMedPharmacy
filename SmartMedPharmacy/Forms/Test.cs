using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartMedPharmacy
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");

            try
            {
                DBConnection db = new DBConnection();

                using (SqlConnection con = db.GetConnection())
                {
                    MessageBox.Show("Trying to open connection...");

                    con.Open();

                    MessageBox.Show("Database Connected Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
