using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryCatalog.Models;

namespace LibraryCatalog
{
    public partial class Form1 : Form
    {
        private List<Book> books;

        public Form1()
        {
            InitializeComponent();

            books = new List<Book>();
            books.Add(new Book()); 

            RefreshListBox();
        }

        private void RefreshListBox()
        {
            lstBooks.Items.Clear();
            foreach (Book b in books)
                lstBooks.Items.Add($"{b.Title} — {b.ISBN}");
        }
        private void ClearInputFields()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtCopies.Clear();
            txtISBN.Focus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string yearTxt = txtYear.Text.Trim();
            string copiesTxt = txtCopies.Text.Trim();

            if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                MessageBox.Show("ISBN, Title, and Author are required.","Missing Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(yearTxt) && string.IsNullOrEmpty(copiesTxt))
            {
                books.Add(new Book(isbn, title, author));
            }
            else
            {
                if (!int.TryParse(yearTxt, out int year))
                {
                    MessageBox.Show("Year Published must be a valid number.", "Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(copiesTxt, out int copies))
                {
                    MessageBox.Show("Copies Available must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                books.Add(new Book(isbn, title, author, year, copies));
            }

            RefreshListBox();
            ClearInputFields();
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBooks.SelectedIndex;
            if (index < 0 || index >= books.Count) return;

            txtDetails.Text = books[index].GetDetails();
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            int index = lstBooks.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a book first.","No Selection", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            bool success = books[index].BorrowCopy();

            if (!success)
            {
                MessageBox.Show("No copies available to borrow.","Borrow Failed", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            txtDetails.Text = books[index].GetDetails();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int index = lstBooks.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a book first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            books[index].ReturnCopy();
            txtDetails.Text = books[index].GetDetails();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lstBooks.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select a book to remove.","No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            books.RemoveAt(index);
            txtDetails.Clear();
            RefreshListBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
