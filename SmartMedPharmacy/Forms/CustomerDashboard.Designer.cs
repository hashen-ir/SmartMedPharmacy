namespace SmartMedPharmacy
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            lblWelcome = new Label();
            btnSearchMedicines = new Button();
            btnPlaceOrders = new Button();
            btnTrackOrders = new Button();
            btnProfile = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(129, 80);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(155, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome,";
            // 
            // btnSearchMedicines
            // 
            btnSearchMedicines.BackColor = Color.PaleTurquoise;
            btnSearchMedicines.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchMedicines.Location = new Point(199, 214);
            btnSearchMedicines.Name = "btnSearchMedicines";
            btnSearchMedicines.Size = new Size(183, 40);
            btnSearchMedicines.TabIndex = 1;
            btnSearchMedicines.Text = "Search Medicines";
            btnSearchMedicines.UseVisualStyleBackColor = false;
            btnSearchMedicines.Click += btnSearchMedicines_Click;
            // 
            // btnPlaceOrders
            // 
            btnPlaceOrders.BackColor = Color.PaleTurquoise;
            btnPlaceOrders.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaceOrders.Location = new Point(472, 214);
            btnPlaceOrders.Name = "btnPlaceOrders";
            btnPlaceOrders.Size = new Size(182, 40);
            btnPlaceOrders.TabIndex = 2;
            btnPlaceOrders.Text = "Place Orders";
            btnPlaceOrders.UseVisualStyleBackColor = false;
            btnPlaceOrders.Click += btnPlaceOrders_Click;
            // 
            // btnTrackOrders
            // 
            btnTrackOrders.BackColor = Color.PaleTurquoise;
            btnTrackOrders.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrackOrders.Location = new Point(199, 308);
            btnTrackOrders.Name = "btnTrackOrders";
            btnTrackOrders.Size = new Size(183, 40);
            btnTrackOrders.TabIndex = 3;
            btnTrackOrders.Text = "Track Orders";
            btnTrackOrders.UseVisualStyleBackColor = false;
            btnTrackOrders.Click += btnTrackOrders_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.PaleTurquoise;
            btnProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(472, 308);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(182, 40);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(28, 443);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(868, 507);
            Controls.Add(btnLogout);
            Controls.Add(btnProfile);
            Controls.Add(btnTrackOrders);
            Controls.Add(btnPlaceOrders);
            Controls.Add(btnSearchMedicines);
            Controls.Add(lblWelcome);
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            Load += CustomerDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnSearchMedicines;
        private Button btnPlaceOrders;
        private Button btnTrackOrders;
        private Button btnProfile;
        private Button btnLogout;
    }
}