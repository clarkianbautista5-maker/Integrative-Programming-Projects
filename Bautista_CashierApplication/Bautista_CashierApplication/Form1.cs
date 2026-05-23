using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bautista_CashierApplication;
using ItemNamespace;
using UserAccountNamespace; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cashier cashier = new Cashier("Clark Ian Bautista", "Finance", "Cashier01", "password123");
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;   
            panel2.Visible = false;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItem.Text = "";
            txtPrice.Text = "";
            txtDiscount.Text = "";
            txtQuantity.Text = "";
            lblTotal.Text = "";
            txtPayment.Text = "";
            lblChange.Text = "";
            txtItem.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPayment.Text))
                {
                    MessageBox.Show("Please enter payment amount!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double payment = Convert.ToDouble(txtPayment.Text);
                double total = Convert.ToDouble(lblTotal.Text);

                if (payment < total)
                {
                    MessageBox.Show("Insufficient payment!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblChange.Text = (payment - total).ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please compute total first!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItem.Text;

                if (string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtDiscount.Text) ||
                    string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("Please fill in all fields!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double price = Convert.ToDouble(txtPrice.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                if (discount > price)
                {
                    MessageBox.Show("Discount cannot be greater than price!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DiscountedItem item = new DiscountedItem(itemName, price, quantity, discount);
                double total = item.getTotalPrice();
                lblTotal.Text = total.ToString("F2");
                lblChange.Text = "0.00";

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in all fields!", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (id == "")
            {
                MessageBox.Show("Username is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Password is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (cashier.validateLogin(id, password))
            {
                MessageBox.Show(
                    "Welcome " + cashier.getFullName() + " of " + cashier.getDepartment(),
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                panel1.Visible = false;
                panel2.Visible = true;
                lblWelcome.Text = "Welcome, " + cashier.getFullName();
            }
            else
            {
                MessageBox.Show("Invalid User ID or Password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
            
                
                panel2.Visible = false; panel1.Visible = true;
            }
        }

        private void exitApplicatonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Are you sure you want to exit?",
              "Exit Application",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}