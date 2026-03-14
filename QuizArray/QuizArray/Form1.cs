using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] classmates = { "Patrick", "Arnel", "Kenzoe", "Sulit", "Roddvincent" };

            foreach (String classmate in classmates)
            {
                listBox1.Items.Add(classmate);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           String textBox = textBox1.Text;
            if (textBox == "hello")
            {
                MessageBox.Show("Wow, you got it right!!!");
            }
            else
            {
                MessageBox.Show("Aww wrong word, Try again!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[,] table = {
                   { "a", "b", "c"},
                   { "d", "e", "f"},
                   };

            
        }
    }
}
