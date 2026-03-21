using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWordApplication
{
    public partial class frmGuessWord : Form
    {
        public frmGuessWord()
        {
            InitializeComponent();
        }

        private string[] words = new string[]
        {
            "computer", "keyboard", "monitor", "programming", "software",
            "application", "database", "network", "variable", "internet",
        };

        private string wordToGuess = "";
        private Random rng = new Random();


        
        private string PickRandomWord()
        {
            int index = rng.Next(0, words.Length);  
            return words[index];
        }

        private void DiasplayGuessWord()
        {
            StringBuilder maskedWord = new StringBuilder();
            maskedWord.Append(wordToGuess[0]);

            for (int i = 1; i < wordToGuess.Length - 1; i++)
                maskedWord.Append('?');

            maskedWord.Append(wordToGuess[wordToGuess.Length - 1]);

            lblWord.Text = maskedWord.ToString();
        }

        
        private void frmGuessWord_Load(object sender, EventArgs e)
        {
            wordToGuess = PickRandomWord();
            DiasplayGuessWord();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.ToLower();

            if (string.IsNullOrWhiteSpace(guess))
            {
                MessageBox.Show("Please enter a word. \nInput Required");
                return;
            }
            if (guess == wordToGuess)
            {
                lblWord.Text = wordToGuess;
                MessageBox.Show("Correct guess!");
            }
            else
            {
                MessageBox.Show("Wrong guess! Try again.");

                
                lstWrong.Items.Add(guess);
            }

            txtGuess.Clear();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            wordToGuess = PickRandomWord();
            DiasplayGuessWord();
            lstWrong.Items.Clear();
            txtGuess.Clear();

        }
    }
}
