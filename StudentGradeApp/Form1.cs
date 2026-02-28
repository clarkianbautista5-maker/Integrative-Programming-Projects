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

namespace StudentGradeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showAverage_Click(object sender, EventArgs e)
        {

        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double math = Double.Parse(mathGrade.Text);
            double english = Double.Parse(englishGrade.Text);
            double history = Double.Parse(historyGrade.Text);
            double filipino = Double.Parse(filipinoGrade.Text);
            double science = Double.Parse(scienceGrade.Text);
            double result = (math + english + history + filipino + science) / 5;
            String name = txtboxName.Text;

            if (result >= 75)
            {
                showAverage.Text = $" The Student passed" +
                         $"\nThe general average of {name} is {result:F2}";
                showAverage.Visible = true;

                
            }
            else
            {
                showAverage.Text = $" The Student failed" +
                          $"\nThe general average of {name} is {result:F2}";
                showAverage.Visible = true;
            }
            
        }
    }
}
