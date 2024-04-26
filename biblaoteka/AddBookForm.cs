using Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_PCHMI
{
    public partial class AddBookForm : Form
    {
        bool BookAlreadyExists(MyBookStorage<Book> books, Book book)
        {
            books.to_beginning();
            for (int i = 0; i < books.size(); i++)
            {
                if (books.getData().name.ToLower() == book.name.ToLower() &&
                    books.getData().author.ToLower() == book.author.ToLower() &&
                    books.getData().isd.ToLower() == book.isd.ToLower() &&
                    books.getData().genre == book.genre)

                {
                    return true;
                }
                books.next();
            }
            return false;
        }
        public AddBookForm()
        {
            InitializeComponent();
            AmountUpDown.Value = 1;
            GenreAddBox.SelectedIndex = 0;
            ErrorLbl.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            if (NameAddBox.Text == "" || AuthorAddBox.Text == "" || IsdAddBox.Text == "" || GenreAddBox.SelectedIndex == null || Convert.ToInt32(AmountUpDown.Value) == null)
            {
                ErrorLbl.Visible = true;
            }
            else
            {
                Book book = new Book(NameAddBox.Text, AuthorAddBox.Text, IsdAddBox.Text, GenreAddBox.SelectedIndex, Convert.ToInt32(AmountUpDown.Value), BookTableForm.book_id);
                if (book != null)
                {
                    if (BookAlreadyExists(BookTableForm.AllBookStorage, book))
                    {
                        BookTableForm.AllBookStorage.Find(book);
                        BookTableForm.AllBookStorage.getData().amount += book.amount;
                    }
                    else
                    {
                        BookTableForm.AllBookStorage.push_back(book);
                        BookTableForm.book_id++;
                    }
                    this.Close();
                }
            }
        }

        private void CancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
