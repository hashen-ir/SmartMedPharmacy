using Microsoft.Data.SqlClient;
using SmartMedPharmacy.Database;
using SmartMedPharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartMedPharmacy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();

            bool isValid = user.Login(
                txtUsername.Text,
                txtPassword.Text);

            if (isValid)
            {
                CustomerDashboard dashboard =
                    new CustomerDashboard();

                dashboard.Show();

                this.Hide();
            }
            else
            {
                Admin admin = new Admin();

                bool adminValid = admin.LoginAdmin(
                    txtUsername.Text,
                    txtPassword.Text);

                if (adminValid)
                {
                    MessageBox.Show("Admin Login Successful");

                    AdminDashboard ad =
                        new AdminDashboard();

                    ad.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();

            register.Show();

            this.Hide();
        }
    }
}
