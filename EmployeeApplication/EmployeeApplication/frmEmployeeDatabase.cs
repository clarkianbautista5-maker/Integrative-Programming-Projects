using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeApplication;


namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        DataTable table = new DataTable("table");
        Employee employee = new Employee();
        public frmEmployeeDatabase()
        {
            InitializeComponent();
            EmployeeData.EnableHeadersVisualStyles = false;
            //header
            EmployeeData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(111, 114, 120);
            EmployeeData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            EmployeeData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            //rows
            EmployeeData.DefaultCellStyle.BackColor = Color.FromArgb(111, 114, 120);
            EmployeeData.DefaultCellStyle.ForeColor = Color.White;
            EmployeeData.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            EmployeeData.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            EmployeeData.DefaultCellStyle.SelectionForeColor = Color.White;
            EmployeeData.GridColor = Color.FromArgb(69, 72, 80);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Position", typeof(string));

            EmployeeData.DataSource = table;

            table.Rows.Add(02000309855, "Clark Ian", "Bautista", "Owner");

            Statistics();
        }

        public void validateInput()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeID.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!long.TryParse(txtEmployeeID.Text, out _))
            {
                MessageBox.Show("Employee ID must be a valid number.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void Statistics()
        {
            int totalEmployee = EmployeeData.RowCount;
            EmployeeStats.Text = ("Total Employee: " + totalEmployee.ToString());
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            employee.EmployeeNumber = long.Parse(txtEmployeeID.Text);
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Position = txtPosition.Text;
            
            validateInput();
            table.Rows.Add(employee.EmployeeNumber, employee.FirstName, employee.LastName, employee.Position);
            Statistics();
            clearFields();
        }

        public void clearFields()
        {
            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();
        }
    }
}
