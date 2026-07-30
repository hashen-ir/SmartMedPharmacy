using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using SmartMedPharmacy.Models;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SmartMedPharmacy
{
    public partial class ReportsForm : Form
    {
        private int customerId = 0;
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadSalesReport()
        {
            Admin admin = new Admin();

            dgvReports.DataSource =
                admin.GetSalesReport();
        }

        private void LoadStockReport()
        {
            Admin admin = new Admin();

            dgvReports.DataSource =
                admin.GetStockReport();
        }

        private void LoadCustomerReport()
        {
            Admin admin = new Admin();

            dgvReports.DataSource =
                admin.GetCustomerOrderHistory(customerId);
            LoadCustomerReport();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            dgvReports.DataSource =
                admin.GetAllCustomerOrderHistory();
        }


        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            LoadStockReport();
        }

        private void btnCustomerHistory_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = new Admin();

                dgvReports.DataSource =
                    admin.GetAllCustomerOrderHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ExportExcel()
        {
            if (dgvReports.DataSource == null)
            {
                MessageBox.Show("No data to export");
                return;
            }

            SaveFileDialog sfd =
                new SaveFileDialog();

            sfd.Filter =
                "Excel Workbook|*.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XLWorkbook wb =
                    new XLWorkbook();

                wb.Worksheets.Add(
                    (DataTable)dgvReports.DataSource,
                    "Report");

                wb.SaveAs(sfd.FileName);

                MessageBox.Show(
                    "Excel Exported Successfully");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvReports.Rows.Count == 0)
            {
                MessageBox.Show("No data to export");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4);

                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));

                doc.Open();

                Paragraph title = new Paragraph("Report Export\n\n");
                doc.Add(title);

                PdfPTable table = new PdfPTable(dgvReports.Columns.Count);

                // Add headers
                foreach (DataGridViewColumn col in dgvReports.Columns)
                {
                    table.AddCell(new Phrase(col.HeaderText));
                }

                // Add rows
                foreach (DataGridViewRow row in dgvReports.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show("PDF Exported Successfully");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = new Admin();

                int customerId =
                    Convert.ToInt32(txtCustomerID.Text);

                DataTable dt =
                    admin.GetCustomerOrderHistory(customerId);

                dgvReports.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found for this customer!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllHistory_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();

            DataTable dt = admin.GetSalesReports(
                dtpFromDate.Value,
                dtpToDate.Value);

            dgvReports.DataSource = dt;

            decimal totalSales = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalSales += Convert.ToDecimal(row["TotalAmount"]);
            }

            lblTotalSales.Text = "Total Sales : Rs. " + totalSales.ToString("N2");
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
