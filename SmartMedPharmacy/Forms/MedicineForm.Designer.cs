namespace SmartMedPharmacy
{
    partial class MedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtName = new TextBox();
            txtSupplier = new TextBox();
            txtDiscount = new TextBox();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtDosage = new TextBox();
            txtCategory = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dtpExpiry = new DateTimePicker();
            dgvMedicine = new DataGridView();
            txtMedicineID = new TextBox();
            lblFinalPrice = new Label();
            txtFinalPrice = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 79);
            label1.Name = "label1";
            label1.Size = new Size(188, 31);
            label1.TabIndex = 0;
            label1.Text = "Medicine Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 112);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 144);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 2;
            label3.Text = "Dosage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 179);
            label4.Name = "label4";
            label4.Size = new Size(73, 31);
            label4.TabIndex = 3;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 214);
            label5.Name = "label5";
            label5.Size = new Size(179, 31);
            label5.TabIndex = 4;
            label5.Text = "Stock Quantity:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(93, 244);
            label6.Name = "label6";
            label6.Size = new Size(111, 31);
            label6.TabIndex = 5;
            label6.Text = "Supplier:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(93, 276);
            label7.Name = "label7";
            label7.Size = new Size(144, 31);
            label7.TabIndex = 6;
            label7.Text = "Expiry Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(93, 309);
            label8.Name = "label8";
            label8.Size = new Size(158, 31);
            label8.TabIndex = 7;
            label8.Text = "Discount (%):";
            // 
            // txtName
            // 
            txtName.Location = new Point(311, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(279, 27);
            txtName.TabIndex = 8;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(311, 250);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(279, 27);
            txtSupplier.TabIndex = 9;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(311, 315);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(279, 27);
            txtDiscount.TabIndex = 11;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(311, 214);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(279, 27);
            txtStock.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(311, 181);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(279, 27);
            txtPrice.TabIndex = 13;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtDosage
            // 
            txtDosage.Location = new Point(311, 148);
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new Size(279, 27);
            txtDosage.TabIndex = 14;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(311, 116);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(279, 27);
            txtCategory.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(794, 89);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 46);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(794, 163);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 47);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(794, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 47);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpExpiry
            // 
            dtpExpiry.Location = new Point(311, 283);
            dtpExpiry.Name = "dtpExpiry";
            dtpExpiry.Size = new Size(279, 27);
            dtpExpiry.TabIndex = 19;
            // 
            // dgvMedicine
            // 
            dgvMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicine.BackgroundColor = Color.FromArgb(200, 231, 249);
            dgvMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicine.GridColor = Color.DodgerBlue;
            dgvMedicine.Location = new Point(46, 389);
            dgvMedicine.Name = "dgvMedicine";
            dgvMedicine.ReadOnly = true;
            dgvMedicine.RowHeadersWidth = 51;
            dgvMedicine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicine.Size = new Size(1067, 188);
            dgvMedicine.TabIndex = 20;
            dgvMedicine.CellContentClick += dgvMedicine_CellContentClick;
            // 
            // txtMedicineID
            // 
            txtMedicineID.Location = new Point(689, 296);
            txtMedicineID.Name = "txtMedicineID";
            txtMedicineID.Size = new Size(262, 27);
            txtMedicineID.TabIndex = 21;
            txtMedicineID.Visible = false;
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.BackColor = Color.Transparent;
            lblFinalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalPrice.Location = new Point(93, 343);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(131, 31);
            lblFinalPrice.TabIndex = 22;
            lblFinalPrice.Text = "Final Price:";
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Location = new Point(311, 348);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.ReadOnly = true;
            txtFinalPrice.Size = new Size(279, 27);
            txtFinalPrice.TabIndex = 23;
            txtFinalPrice.TextChanged += txtFinalPrice_TextChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.WhiteSmoke;
            btnBack.Location = new Point(1003, 163);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 39);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1164, 613);
            Controls.Add(btnBack);
            Controls.Add(txtFinalPrice);
            Controls.Add(lblFinalPrice);
            Controls.Add(txtMedicineID);
            Controls.Add(dgvMedicine);
            Controls.Add(dtpExpiry);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtCategory);
            Controls.Add(txtDosage);
            Controls.Add(txtPrice);
            Controls.Add(txtStock);
            Controls.Add(txtDiscount);
            Controls.Add(txtSupplier);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MedicineForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicineForm";
            Load += MedicineForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtName;
        private TextBox txtSupplier;
        private TextBox txtDiscount;
        private TextBox txtStock;
        private TextBox txtPrice;
        private TextBox txtDosage;
        private TextBox txtCategory;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DateTimePicker dtpExpiry;
        private DataGridView dgvMedicine;
        private TextBox txtMedicineID;
        private Label lblFinalPrice;
        private TextBox txtFinalPrice;
        private Button btnBack;
    }
}