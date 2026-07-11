namespace SmartMedPharmacy.Forms
{
    partial class InvoiceForm
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
            lblInvoiceNo = new Label();
            lblCustomer = new Label();
            lblDate = new Label();
            lblGrandTotal = new Label();
            dgvInvoice = new DataGridView();
            btnPrint = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).BeginInit();
            SuspendLayout();
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Location = new Point(33, 71);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(50, 20);
            lblInvoiceNo.TabIndex = 0;
            lblInvoiceNo.Text = "label1";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(33, 109);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(50, 20);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "label2";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(33, 149);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(50, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "label3";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Location = new Point(33, 384);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(50, 20);
            lblGrandTotal.TabIndex = 3;
            lblGrandTotal.Text = "label4";
            // 
            // dgvInvoice
            // 
            dgvInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoice.Location = new Point(111, 179);
            dgvInvoice.Name = "dgvInvoice";
            dgvInvoice.RowHeadersWidth = 51;
            dgvInvoice.Size = new Size(300, 188);
            dgvInvoice.TabIndex = 4;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(718, 118);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(718, 206);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 575);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(dgvInvoice);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblDate);
            Controls.Add(lblCustomer);
            Controls.Add(lblInvoiceNo);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            Load += InvoiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvoiceNo;
        private Label lblCustomer;
        private Label lblDate;
        private Label lblGrandTotal;
        private DataGridView dgvInvoice;
        private Button btnPrint;
        private Button btnClose;
    }
}