using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10TP_Payroll_Bautista
{
    public partial class frmLogin : Form
    {
        private string correctUsername = "admin";
        private string correctPassword = "admin123";

        // Track failed attempts
        private int attempts = 0;
        private int maxAttempts = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validate empty fields
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check credentials using Equals()
            if (username.Equals(correctUsername) && password.Equals(correctPassword))
            {
                // Login success — open main form
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();
            }
            else
            {
                attempts++;
                int remaining = maxAttempts - attempts;

                if (remaining > 0)
                {
                    MessageBox.Show("Invalid username or password.\n" +
                        remaining + " attempt(s) remaining.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPassword.Text = "";
                    txtPassword.Focus();
                    lblAttempts.Text = "Attempts remaining: " + remaining;
                    lblAttempts.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    MessageBox.Show("Too many failed attempts. The program will now close.",
                        "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        

        // Allow pressing Enter to login
        private void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        
    }
}
