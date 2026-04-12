using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bautista_StudentGradeAnalyzer
{
    public partial class studentgradefrm : Form
    {
        DataTable table = new DataTable("table");

        // REQUIREMENT 3: The Structure
        public struct StudentData
        {
            public string StudentNumber;
            public string Name;
            public double Prelim;
            public double Midterm;
            public double Final;
            public double Average;
            public string Remarks;
        }

        public studentgradefrm()
        {
            InitializeComponent();
            studentData.EnableHeadersVisualStyles = false;
            //header
            studentData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 90, 108);
            studentData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            studentData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            //rows
            studentData.DefaultCellStyle.BackColor = Color.FromArgb(44, 90, 108);
            studentData.DefaultCellStyle.ForeColor = Color.White;
            studentData.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            studentData.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            studentData.DefaultCellStyle.SelectionForeColor = Color.White;
            studentData.GridColor = Color.FromArgb(44, 90, 108);
        }

        private void studentgradefrm_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Student Number", typeof(long));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Prelim", typeof(double));
            table.Columns.Add("Midterm", typeof(double));
            table.Columns.Add("Final", typeof(double)); 
            table.Columns.Add("Average", typeof(double));
            table.Columns.Add("Remarks", typeof(string));

            studentData.DataSource = table;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string studentNumber = txtStudentNumber.Text;
            string name = txtStudentName.Text;
            string prelim = txtPrelim.Text;
            string midterm = txtMidterm.Text;
            string final = txtFinal.Text;

            if (ValidateInput(studentNumber, name, prelim, midterm, final))
            {
                StudentData currentStudent = new StudentData();
                currentStudent.StudentNumber = studentNumber;
                currentStudent.Name = name;
                currentStudent.Prelim = double.Parse(prelim);
                currentStudent.Midterm = double.Parse(midterm);

                if (string.IsNullOrWhiteSpace(final))
                {
                    currentStudent.Final = 0;
                    currentStudent.Average = CalculateAverage(currentStudent.Prelim, currentStudent.Midterm);
                }
                else
                {
                    currentStudent.Final = double.Parse(final);
                    currentStudent.Average = CalculateAverage(currentStudent.Prelim, currentStudent.Midterm, currentStudent.Final);
                }

                currentStudent.Remarks = GetRemarks(currentStudent.Average);

                AddStudentRecord(currentStudent);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        public bool ValidateInput(string studentNumber, string name, string prelim, string midterm, string final)
        {
            if (string.IsNullOrWhiteSpace(studentNumber) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(prelim) || string.IsNullOrWhiteSpace(midterm))
            {
                MessageBox.Show("Please fill in Student Number, Name, Prelim, and Midterm.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!long.TryParse(studentNumber, out _))
            {
                MessageBox.Show("Student Number must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(prelim, out _) || !double.TryParse(midterm, out _))
            {
                MessageBox.Show("Prelim and Midterm must be valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!string.IsNullOrWhiteSpace(final) && !double.TryParse(final, out _))
            {
                MessageBox.Show("Final must be a valid number if provided.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void AddStudentRecord(StudentData student)
        {
            table.Rows.Add(student.StudentNumber, student.Name, student.Prelim, student.Midterm, student.Final, student.Average, student.Remarks);
        }
        public double CalculateAverage(double prelim, double midterm)
        {
            return (prelim + midterm) / 2;
        }
        public double CalculateAverage(double prelim, double midterm, double final)
        {
            return (prelim + midterm + final) / 3;
        }
        public static string GetRemarks(double average)
        {
            if (average >= 75)
                return "Passed";
            else
                return "Failed";
        }

        public void ClearInputFields()
        {
            txtStudentNumber.Clear();
            txtStudentName.Clear();
            txtPrelim.Clear();
            txtMidterm.Clear();
            txtFinal.Clear();
            table.Rows.Clear();
            txtStudentNumber.Focus();
        }

    }
}
