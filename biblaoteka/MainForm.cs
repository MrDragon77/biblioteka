using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblaoteka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("going to BooksForm");
            this.Close();
            //BooksForm booksForm = new BooksForm();
            //booksForm.Show();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("going to AddBookForm");
            this.Close();
            //AddBookForm addBookForm = new AddBookForm();
            //addBookForm.Show();
        }

        private void ReadersButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("going to ReadersForm");
            this.Close();
            ReadersForm readersForm = new ReadersForm();
            readersForm.Show();
        }
    }
}
