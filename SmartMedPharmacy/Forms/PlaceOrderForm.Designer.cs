namespace SmartMedPharmacy
{
    partial class PlaceOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceOrderForm));
            label1 = new Label();
            dgvMedicines = new DataGridView();
            label2 = new Label();
            numQuantity = new NumericUpDown();
            btnAddToCart = new Button();
            btnPlaceOrder = new Button();
            btnUploadPrescription = new Button();
            lblPrescription = new Label();
            btnBack = new Button();
            label3 = new Label();
            lblCartItems = new Label();
            btnRemove = new Button();
            dgvCart = new DataGridView();
            txtSearch = new TextBox();
            lblTotalAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 100);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 0;
            label1.Text = "Available Medicines";
            // 
            // dgvMedicines
            // 
            dgvMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicines.BackgroundColor = Color.PaleTurquoise;
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicines.Location = new Point(12, 143);
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.ReadOnly = true;
            dgvMedicines.RowHeadersWidth = 51;
            dgvMedicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicines.Size = new Size(596, 127);
            dgvMedicines.TabIndex = 1;
            dgvMedicines.CellClick += dgvMedicines_CellClick;
            dgvMedicines.CellContentClick += dgvMedicines_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(242, 287);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "Quantity:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(340, 287);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(220, 27);
            numQuantity.TabIndex = 3;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.Moccasin;
            btnAddToCart.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.Location = new Point(654, 347);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(167, 47);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.LawnGreen;
            btnPlaceOrder.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaceOrder.Location = new Point(908, 347);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(189, 47);
            btnPlaceOrder.TabIndex = 5;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnUploadPrescription
            // 
            btnUploadPrescription.BackColor = Color.RosyBrown;
            btnUploadPrescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadPrescription.Location = new Point(96, 348);
            btnUploadPrescription.Name = "btnUploadPrescription";
            btnUploadPrescription.Size = new Size(235, 46);
            btnUploadPrescription.TabIndex = 6;
            btnUploadPrescription.Text = "Upload Prescription";
            btnUploadPrescription.UseVisualStyleBackColor = false;
            btnUploadPrescription.Click += btnUploadPrescription_Click;
            // 
            // lblPrescription
            // 
            lblPrescription.AutoSize = true;
            lblPrescription.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrescription.Location = new Point(117, 408);
            lblPrescription.Name = "lblPrescription";
            lblPrescription.Size = new Size(106, 20);
            lblPrescription.TabIndex = 7;
            lblPrescription.Text = "No file selected";
            lblPrescription.Click += lblPrescription_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gainsboro;
            btnBack.Location = new Point(1034, 505);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 36);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(491, 33);
            label3.Name = "label3";
            label3.Size = new Size(168, 38);
            label3.TabIndex = 9;
            label3.Text = "Place Order";
            // 
            // lblCartItems
            // 
            lblCartItems.AutoSize = true;
            lblCartItems.BackColor = Color.Transparent;
            lblCartItems.Location = new Point(927, 283);
            lblCartItems.Name = "lblCartItems";
            lblCartItems.Size = new Size(91, 20);
            lblCartItems.TabIndex = 10;
            lblCartItems.Text = "Cart Items: 0";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.IndianRed;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(1072, 283);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // dgvCart
            // 
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.PaleTurquoise;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(664, 143);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(502, 127);
            dgvCart.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(305, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(164, 27);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(1034, 117);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(122, 23);
            lblTotalAmount.TabIndex = 14;
            lblTotalAmount.Text = "Total : Rs.0.00";
            // 
            // PlaceOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1178, 573);
            Controls.Add(lblTotalAmount);
            Controls.Add(txtSearch);
            Controls.Add(dgvCart);
            Controls.Add(btnRemove);
            Controls.Add(lblCartItems);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(lblPrescription);
            Controls.Add(btnUploadPrescription);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnAddToCart);
            Controls.Add(numQuantity);
            Controls.Add(label2);
            Controls.Add(dgvMedicines);
            Controls.Add(label1);
            Name = "PlaceOrderForm";
            Text = "PlaceOrderForm";
            Load += PlaceOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvMedicines;
        private Label label2;
        private NumericUpDown numQuantity;
        private Button btnAddToCart;
        private Button btnPlaceOrder;
        private Button btnUploadPrescription;
        private Label lblPrescription;
        private Button btnBack;
        private Label label3;
        private Label lblCartItems;
        private Button btnRemove;
        private DataGridView dgvCart;
        private TextBox txtSearch;
        private Label lblTotalAmount;
    }
}