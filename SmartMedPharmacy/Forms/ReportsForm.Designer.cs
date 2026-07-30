namespace SmartMedPharmacy
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            label1 = new Label();
            btnSalesReport = new Button();
            btnStockReport = new Button();
            btnCustomerHistory = new Button();
            dgvReports = new DataGridView();
            label2 = new Label();
            txtCustomerID = new TextBox();
            btnExportExcel = new Button();
            btnExportPDF = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            lblTotalSales = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 24);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 0;
            label1.Text = "REPORTS FORM";
            // 
            // btnSalesReport
            // 
            btnSalesReport.BackColor = Color.FromArgb(52, 152, 219);
            btnSalesReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalesReport.Location = new Point(149, 107);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(165, 42);
            btnSalesReport.TabIndex = 1;
            btnSalesReport.Text = "Sales Report";
            btnSalesReport.UseVisualStyleBackColor = false;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnStockReport
            // 
            btnStockReport.BackColor = Color.FromArgb(243, 156, 18);
            btnStockReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStockReport.Location = new Point(376, 107);
            btnStockReport.Name = "btnStockReport";
            btnStockReport.Size = new Size(156, 42);
            btnStockReport.TabIndex = 2;
            btnStockReport.Text = "Stock Report";
            btnStockReport.UseVisualStyleBackColor = false;
            btnStockReport.Click += btnStockReport_Click;
            // 
            // btnCustomerHistory
            // 
            btnCustomerHistory.BackColor = Color.FromArgb(155, 89, 182);
            btnCustomerHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerHistory.Location = new Point(599, 107);
            btnCustomerHistory.Name = "btnCustomerHistory";
            btnCustomerHistory.Size = new Size(198, 42);
            btnCustomerHistory.TabIndex = 3;
            btnCustomerHistory.Text = "Customer History";
            btnCustomerHistory.UseVisualStyleBackColor = false;
            btnCustomerHistory.Click += btnCustomerHistory_Click;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.SkyBlue;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.GridColor = Color.SkyBlue;
            dgvReports.Location = new Point(91, 232);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersWidth = 51;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(984, 188);
            dgvReports.TabIndex = 4;
            dgvReports.CellContentClick += dgvReports_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 179);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 5;
            label2.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(211, 183);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(204, 27);
            txtCustomerID.TabIndex = 6;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(39, 174, 96);
            btnExportExcel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportExcel.Location = new Point(506, 449);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(166, 39);
            btnExportExcel.TabIndex = 7;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.FromArgb(231, 76, 60);
            btnExportPDF.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportPDF.Location = new Point(765, 449);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(147, 38);
            btnExportPDF.TabIndex = 8;
            btnExportPDF.Text = "Export PDF";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonFace;
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(61, 473);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Lavender;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(506, 182);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(662, 181);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(250, 27);
            dtpFromDate.TabIndex = 12;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(928, 179);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(250, 27);
            dtpToDate.TabIndex = 13;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(1081, 218);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(80, 20);
            lblTotalSales.TabIndex = 14;
            lblTotalSales.Text = "Total Sales";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(877, 110);
            button1.Name = "button1";
            button1.Size = new Size(149, 40);
            button1.TabIndex = 15;
            button1.Text = "GenerateReport";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1243, 536);
            Controls.Add(button1);
            Controls.Add(lblTotalSales);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(btnSearch);
            Controls.Add(btnBack);
            Controls.Add(btnExportPDF);
            Controls.Add(btnExportExcel);
            Controls.Add(txtCustomerID);
            Controls.Add(label2);
            Controls.Add(dgvReports);
            Controls.Add(btnCustomerHistory);
            Controls.Add(btnStockReport);
            Controls.Add(btnSalesReport);
            Controls.Add(label1);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSalesReport;
        private Button btnStockReport;
        private Button btnCustomerHistory;
        private DataGridView dgvReports;
        private Label label2;
        private TextBox txtCustomerID;
        private Button btnExportExcel;
        private Button btnExportPDF;
        private Button btnBack;
        private Button btnSearch;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Label lblTotalSales;
        private Button button1;
    }
}