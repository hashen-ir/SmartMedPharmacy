using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartMedPharmacy.Forms
{
    public partial class InvoiceForm : Form
    {
        private int orderId;
        public InvoiceForm(int orderId)
        {
            this.orderId = orderId;
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            DataTable dt = customer.GetInvoice(orderId);

            dgvInvoice.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                lblInvoiceNo.Text = dt.Rows[0]["OrderID"].ToString();

                lblCustomer.Text = dt.Rows[0]["FullName"].ToString();

                lblDate.Text =
                    Convert.ToDateTime(dt.Rows[0]["OrderDate"])
                    .ToString("dd/MM/yyyy");
            }

            decimal grandTotal = 0;

            foreach (DataRow row in dt.Rows)
            {
                grandTotal += Convert.ToDecimal(row["Total"]);
            }

            lblGrandTotal.Text = "Rs. " + grandTotal.ToString("N2");
        }
    }
}
