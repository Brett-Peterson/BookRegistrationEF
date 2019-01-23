using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistrationEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateBookList();

        }

        private void PopulateBookList()
        {
            List<Book> books = BookDb.GetAllBooks();
            cboBooks.DataSource = books;
            cboBooks.DisplayMember = nameof(Book.Title);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.ISBN = "789123";
            b.Title = "Good Book";
            b.Price = 10;
            BookDb.AddBook(b);
            MessageBox.Show("Book Added");
        }
    }
}
