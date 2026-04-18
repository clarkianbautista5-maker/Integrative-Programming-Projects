using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        ArrayList studentList = new ArrayList();

        public frmStudentInfo()
        {
            InitializeComponent();
            studentList.Add(new Student("02000309855", "Bautista", "Clark Ian"));
            studentList.Add(new Student("02000396824", "Herrera", "John Patrick"));


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
           if (txtStudentID.Text == "" || txtLastName.Text == "" || txtFirstName.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.","Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(txtStudentID.Text, @"^02000\d{6}$"))
            {
                MessageBox.Show("Student ID must start with 02000 followed by 6 digits..", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentID.Clear();
                return;
            }
            Student student = new Student(txtStudentID.Text, txtLastName.Text, txtFirstName.Text);
            lstStudentNumber.Items.Add(student.StudentID);
            lstLastName.Items.Add(student.StudentLastName);
            lstFirstName.Items.Add(student.StudentFirstName);
            studentList.Add(student);
            Statistics();


            fieldsClear.ClearFields(this);

        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            foreach (Student student in studentList)
            {
                lstStudentNumber.Items.Add(student.StudentID);
                lstLastName.Items.Add(student.StudentLastName);
                lstFirstName.Items.Add(student.StudentFirstName);
                
            }

            int totalStudents = studentList.Count;
            lblTotalStudentsCounter.Text = totalStudents.ToString();

        }

        public void Statistics()
        {
            int totalStudents = studentList.Count;
            lblTotalStudentsCounter.Text = totalStudents.ToString();

            int counter = +1;
            lblNewStudentsCounter.Text = counter.ToString();

        }

        public void clearRecords()
        {
            lstStudentNumber.Items.Clear();
            lstFirstName.Items.Clear();
            lstLastName.Items.Clear();
            lblTotalStudentsCounter.Text = "0";
            lblNewStudentsCounter.Text = "0";
        }

        class Student
        {
            private string id, lastName, firstName;
           

            public Student()
            {
                this.id = "";
                this.lastName = "";
                this.firstName = "";
            }
            public Student(String id, string lastName, string firstName)
            {
                this.id = id;
                this.lastName = lastName;
                this.firstName = firstName;
            }

            public String StudentID
            {
                get
                {
                    return id;
                }
                set
                {
                    this.id = value;
                }
            }
            public String StudentLastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    this.lastName = value;
                }
            }
            public string StudentFirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    this.firstName = value;
                }
            }

        }

        class fieldsClear         {
            public static void ClearFields(Form form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Clear();
                    }
                }
            }
        }

        private void btnClearRecords_Click(object sender, EventArgs e)
        {
            clearRecords();
        }
    }
}
