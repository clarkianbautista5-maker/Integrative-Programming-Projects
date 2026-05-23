using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserNamespace;

namespace _10HandsOn_Inheritance
{
    public partial class Form1 : Form
{
    private Administrator admin = new Administrator("Admin User", "admin01", "pass123");

    public Form1()
    {
        InitializeComponent();
        txtAdminName.Text = admin.GetAdminName();
        txtUserId.Text = admin.GetUserId();
    }

    private void btnVerify_Click_1(object sender, EventArgs e)
    {
            if (txtInputId.Text == "" || txtInputPass.Text == "")
            {
                MessageBox.Show("Please enter User ID and Password.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = admin.verifyLogin(txtInputId.Text, txtInputPass.Text);

            if (result)
            {
                lblResult.Text = "Login Successful! Welcome, " + admin.GetAdminName();
                lblResult.ForeColor = System.Drawing.Color.Green;
                listBox1.Items.Add("Login Successful - " + admin.GetAdminName());
            }
            else
            {
                lblResult.Text = "Login Failed. Invalid credentials.";
                lblResult.ForeColor = System.Drawing.Color.Red;
                listBox1.Items.Add("Login Failed - Invalid credentials.");
            }
    }

        private void btnUpdatePass_Click(object sender, EventArgs e)
    {
        if (txtNewPass.Text == "")
        {
            MessageBox.Show("Please enter a new password.", "Input Required",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        admin.updatePassword(txtNewPass.Text);
        listBox1.Items.Add("Password updated successfully.");
        MessageBox.Show("Password updated successfully!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtNewPass.Text = "";
        lblResult.Text = "";
    }

    private void btnUpdateName_Click(object sender, EventArgs e)
    {
        if (txtNewName.Text == "")
        {
            MessageBox.Show("Please enter a new admin name.", "Input Required",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        admin.updateAdminName(txtNewName.Text);
        txtAdminName.Text = admin.GetAdminName();
        listBox1.Items.Add("Admin name updated to: " + admin.GetAdminName());
        MessageBox.Show("Admin name updated to: " + admin.GetAdminName(), "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtNewName.Text = "";
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtInputId.Text = "";
        txtInputPass.Text = "";
        txtNewPass.Text = "";
        txtNewName.Text = "";
        lblResult.Text = "";
        listBox1.Items.Clear();
        txtInputId.Focus();
    }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 