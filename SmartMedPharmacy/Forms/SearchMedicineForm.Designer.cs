namespace SmartMedPharmacy
{
    partial class SearchMedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMedicineForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSearch = new TextBox();
            txtMinPrice = new TextBox();
            txtMaxPrice = new TextBox();
            cmbCategory = new ComboBox();
            btnSearch = new Button();
            dgvMedicines = new DataGridView();
            btnBack = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 76);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 0;
            label1.Text = "Search by Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 120);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 162);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "Min Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(125, 200);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 3;
            label4.Text = "Max Price:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(299, 74);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(270, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(299, 163);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(270, 27);
            txtMinPrice.TabIndex = 6;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(299, 200);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(270, 27);
            txtMaxPrice.TabIndex = 7;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Painkiller", "Antibiotic", "Vitamin", "Syrup", "Tablet" });
            cmbCategory.Location = new Point(299, 117);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(270, 28);
            cmbCategory.TabIndex = 8;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(733, 200);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 47);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvMedicines
            // 
            dgvMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicines.BackgroundColor = Color.PaleTurquoise;
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicines.Location = new Point(67, 295);
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.ReadOnly = true;
            dgvMedicines.RowHeadersWidth = 51;
            dgvMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicines.Size = new Size(786, 163);
            dgvMedicines.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(819, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(360, 21);
            label5.Name = "label5";
            label5.Size = new Size(234, 40);
            label5.TabIndex = 12;
            label5.Text = "Search Medicine";
            // 
            // SearchMedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(943, 486);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(dgvMedicines);
            Controls.Add(btnSearch);
            Controls.Add(cmbCategory);
            Controls.Add(txtMaxPrice);
            Controls.Add(txtMinPrice);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchMedicineForm";
            Text = "SearchMedicineForm";
            Load += SearchMedicineForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSearch;
        private TextBox txtMinPrice;
        private TextBox txtMaxPrice;
        private ComboBox cmbCategory;
        private Button btnSearch;
        private DataGridView dgvMedicines;
        private Button btnBack;
        private Label label5;
    }
}