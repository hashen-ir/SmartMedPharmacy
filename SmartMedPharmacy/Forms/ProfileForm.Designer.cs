namespace SmartMedPharmacy
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtCustomerID = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            btnLoad = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(161, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(148, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Customer Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(161, 128);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(131, 25);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email Address";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(161, 170);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(140, 25);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone Number";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(161, 204);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(80, 25);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 223);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(333, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(278, 27);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(333, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(333, 163);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(333, 205);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(278, 27);
            txtAddress.TabIndex = 8;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(334, 250);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(277, 27);
            txtCustomerID.TabIndex = 9;
            txtCustomerID.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SpringGreen;
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(168, 317);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(181, 49);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 18);
            label1.Name = "label1";
            label1.Size = new Size(186, 38);
            label1.TabIndex = 11;
            label1.Text = " MY PROFILE";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.LightSkyBlue;
            btnLoad.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.Location = new Point(410, 317);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(181, 49);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gainsboro;
            btnBack.Location = new Point(632, 395);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(761, 450);
            Controls.Add(btnBack);
            Controls.Add(btnLoad);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(txtCustomerID);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(lblAddress);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblAddress;
        private Label label5;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtCustomerID;
        private Button btnUpdate;
        private Label label1;
        private Button btnLoad;
        private Button btnBack;
    }
}