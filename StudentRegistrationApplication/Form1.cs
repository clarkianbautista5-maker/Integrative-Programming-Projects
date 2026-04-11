using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                cmbDay.Items.Add(day);
            }
            cmbDay.Text = "-Day-";

            string[] months = { "January", "February", "March", "April", "May", "June",
                                 "July", "August", "September", "October", "November", "December" };
            foreach (string month in months)
            {
                cmbMonth.Items.Add(month);
            }
            cmbMonth.Text = "-Month-";

            for (int year = 1940; year <= DateTime.Now.Year; year++)
            {
                cmbYear.Items.Add(year);
            }
            cmbYear.Text = "-Year-";

            String[] courses = { "BS Computer Science", "BS Information Technology", "BS Computer Engineering",
                                 "BS Education", "Hospitality Management", "Tourism Management", "BS Information Sytem" };
            foreach (String course in courses)
            {
                cmbCourse.Items.Add(course);
            }
            cmbCourse.Text = "-Select Course-";
        }

        private void registerStudentBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxMiddleName.Text) ||
                cmbCourse.SelectedIndex == -1 ||
                cmbDay.SelectedIndex == -1 ||
                cmbMonth.SelectedIndex == -1 ||
                cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields and select options.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String lastName = txtBoxLastName.Text;
            String firstName = txtBoxFirstName.Text;
            String middleName = txtBoxMiddleName.Text;
            String course = cmbCourse.SelectedItem?.ToString() ?? "N/A";
            String birthDate = $"{cmbMonth.SelectedItem} {cmbDay.SelectedItem}, {cmbYear.SelectedItem}";
            String Gender = rdBtnFemale.Checked ? "Female" : rdBtnMale.Checked ? "Male" : "N/A";

            if (middleName == "")
            {
                middleName = "";
            }
            Student(firstName, middleName, lastName, Gender, birthDate, course);
            Student(firstName, middleName, lastName, course);
            Student(firstName, lastName, course);
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        public void Student(string firstName, string middleName, string lastName, string Gender, string birthDate, string course)
        {

            String message = $"Student Name: {lastName}, {firstName} {middleName}\n" +
                              $"Course: {course}\n" +
                              $"Birth Date: {birthDate}\n" +
                              $"Gender: {Gender}";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Student(string firstName, string middleName, string lastName, string course)
        {

            String message = $"Student Name: {lastName}, {firstName} {middleName}\n" +
                              $"Course: {course}";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Student(string firstName, string lastName, string course)
        {

            String message = $"Student Name: {lastName}, {firstName}\n" +
                              $"Course: {course}";

            MessageBox.Show(message, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}