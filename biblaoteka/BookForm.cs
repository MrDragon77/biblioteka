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

namespace biblaoteka
{
    public partial class BookForm : Form
    {
        int book_id;
        public BookForm(int index, Book book)
        {
            book_id = index;
            InitializeComponent();
            IdTextBox.Text = index.ToString();
            NameTextBox.Text = book.name;
            AuthorTextBox.Text = book.author;
            IsdTextBox.Text = book.isd;
            GenreBox.SelectedIndex = book.genre;
            AmountTextBox.Text = book.amount.ToString();
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            BookTableForm.AllBookStorage.FindById(book_id);
            BookTableForm.AllBookStorage.getData().name = NameTextBox.Text;
            BookTableForm.AllBookStorage.getData().author = AuthorTextBox.Text;
            BookTableForm.AllBookStorage.getData().isd = IsdTextBox.Text;
            BookTableForm.AllBookStorage.getData().genre = GenreBox.SelectedIndex;
            BookTableForm.AllBookStorage.getData().amount = Int32.Parse(AmountTextBox.Text);
            BookTableForm.SaveBooks("Books.txt");
        }

        private void LendBtn_Click(object sender, EventArgs e)
        {
            LendForm lendForm = new LendForm(true,book_id, 0);
            this.Close();
            lendForm.ShowDialog();
        }
    }
}
