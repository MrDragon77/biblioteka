using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblaoteka
{
    public partial class LendForm : Form
    {
        string pathToDB_takenBooks = "TakenBooks.txt";
        //string pathToDB_books = "Books.txt";
        string pathToDB_readers = "Readers.txt";
        bool lendMode = true; //true - выдача, false - приём книги
        //string[] savedBook = new string[n];
        string[] savedReader = new string[2];
        public LendForm()
        {
            InitializeComponent();
        }
        public LendForm(bool lendMode, int bookIndex, int readerIndex)
        {
            this.lendMode = lendMode;
            InitializeComponent();
            if(lendMode)
            {
                //visible to lend mode true items must be visible = true;
                //items are not connected to lend mode true must be invisible;
            }
            {
                //analog
            }

            //read book from file by index
            if (bookIndex == 0)
            {
                //make ChooseBookButton visible
                //MoreBookButton - invisible
            }
            else
            {
                //load book
            }

            //read reader from file by index
            if (readerIndex == 0)
            {
                //make ChooseReaderButton visible
                //MoreReaderButton - invisible
            }
            else
            {
                FileStream fs = new FileStream(pathToDB_readers, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');

                    if (Int32.Parse(line[0]) == readerIndex)
                    {
                        savedReader = new string[4];
                        savedReader[0] = line[0];
                        savedReader[1] = line[1] + ' ' + line[2] + ' ' + line[3];
                    }
                }
                LoadSavedReader();
                //SaveChangesButton.Visible = false;
                //DiscardChangesButton.Visible = false;
                fs.Close();
            }



        }
        //for loading book from code to form
        //private void LoadSavedBook()
        //{
        //    BookIndexTextBox.Text = savedBook[0];
        //    BookFullNameTextBox.Text = savedBook[1];
        //}
        //for saving book from form to code
        //private void SaveBook()
        //{
        //    savedBook[0] = BookIndexTextBox.Text;
        //    savedBook[1] = BookFullNameTextBox.Text;
        //}
        private void LoadSavedReader()
        {
            ReaderIndexTextBox.Text = savedReader[0];
            ReaderFullNameTextBox.Text = savedReader[1];
        }
        private void SaveReader()
        {
            savedReader[0] = ReaderIndexTextBox.Text;
            savedReader[1] = ReaderFullNameTextBox.Text;
        }
    }
}
