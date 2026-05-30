using PayrollNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PayrollNamespace;

namespace _10TP_Payroll_Bautista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbFullTime_CheckedChanged(object sender, EventArgs e)
        {
            grpFullTime.Visible = rbFullTime.Checked;
            grpPartTime.Visible = !rbFullTime.Checked;
        }

        private void rbPartTime_CheckedChanged(object sender, EventArgs e)
        {
            grpPartTime.Visible = rbPartTime.Checked;
            grpFullTime.Visible = !rbPartTime.Checked;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (txtfName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the employee first name.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtlName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the employee last name.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rbFullTime.Checked && !rbPartTime.Checked)
            {
                MessageBox.Show("Please select Full Time or Part Time.",
                    "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtfName.Text.Trim();

            if (rbFullTime.Checked)
            {
                if (txtMonthlySalary.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter the monthly salary.",
                        "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double salary = Convert.ToDouble(txtMonthlySalary.Text);

                FullTimeEmployee fte = new FullTimeEmployee(name, salary);

                fte.FirstName = txtfName.Text.Trim();
                fte.LastName = txtlName.Text.Trim();
                fte.Department = txtDepartment.Text.Trim();
                txtEmployeeType.Text = "Part Time Employee";
                txtDisplayDepartment.Text = fte.Department;
                txtTittle.Text = fte.JobTitle;
                txtDisplayName.Text = fte.getName();
                txtEmployeeType.Text = "Full Time Employee";
                txtDisplayName.Text = fte.getName();
                txtDisplayTittle.Text = fte.JobTitle;
                txtPay.Text = "Monthly Salary: " + fte.getMonthlySalary().ToString("F2");

                listBox1.Items.Add("-------------------------------");
                listBox1.Items.Add("Employee Type  : Full Time");
                listBox1.Items.Add("Name           : " + fte.FirstName + " " + fte.LastName);
                listBox1.Items.Add("Department     : " + fte.Department);
                listBox1.Items.Add("Job Title      : " + fte.JobTitle);
                listBox1.Items.Add("Monthly Salary : " + fte.computeSalary().ToString("F2"));
            }
            else if (rbPartTime.Checked)
            {
                if (txtRatePerHour.Text.Trim() == "" || txtHoursWorked.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter rate per hour and hours worked.",
                        "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double rate = Convert.ToDouble(txtRatePerHour.Text);
                int hours = Convert.ToInt32(txtHoursWorked.Text);

                PartTimeEmployee pte = new PartTimeEmployee(name, rate, hours);


                pte.FirstName = txtfName.Text.Trim();
                pte.LastName = txtlName.Text.Trim(); 
                pte.Department = txtDepartment.Text.Trim();
                pte.JobTitle = txtTittle.Text.Trim();
                txtEmployeeType.Text = "Part Time Employee";
                txtDisplayDepartment.Text = pte.Department;
                txtDisplayTittle.Text = pte.JobTitle;
                txtDisplayName.Text = pte.getName();
                txtPay.Text = "Wage: " + pte.getSalary().ToString("F2");
                txtDepartment.Text = "N/A";

                listBox1.Items.Add("-------------------------------");
                listBox1.Items.Add("Employee Type  : Part Time");
                listBox1.Items.Add("Name           : " + pte.FirstName +" "+ pte.LastName);
                listBox1.Items.Add("Department     : " + pte.Department);
                listBox1.Items.Add("Job Title      : " + pte.JobTitle);
                listBox1.Items.Add("Rate Per Hour  : " + pte.getRatePerHour().ToString("F2"));
                listBox1.Items.Add("Hours Worked   : " + pte.getHoursWorked());
                listBox1.Items.Add("Total Wage     : " + pte.computeSalary().ToString("F2"));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtfName.Text = "";
            txtMonthlySalary.Text = "";
            txtRatePerHour.Text = "";
            txtHoursWorked.Text = "";
            txtEmployeeType.Text = "";
            txtDisplayName.Text = "";
            txtPay.Text = "";
            rbFullTime.Checked = false;
            rbPartTime.Checked = false;
            grpFullTime.Visible = false;
            grpPartTime.Visible = false;
            listBox1.Items.Clear();
            txtfName.Focus();
        }

        private void grpEmployee_Enter(object sender, EventArgs e)
        {

        }
    }
}
