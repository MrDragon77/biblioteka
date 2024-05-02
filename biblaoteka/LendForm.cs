using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        BookTableForm bookTableForm = new BookTableForm(true);
        string pathToDB_takenBooks = "TakenBooks.txt";
        //структура файла: id_операции id_книги id_читателя дата
        //string pathToDB_books = "Books.txt";
        string pathToDB_readers = "Readers.txt";
        bool lendMode = true; //true - выдача, false - приём книги
        //string[] savedBook = new string[2];
        Books.Book savedBook = new Books.Book();
        string[] savedReader = new string[2];
        bool readerChoosen = false;
        bool bookChoosen = false;
        public LendForm()
        {
            bookTableForm = new BookTableForm(true);
            InitializeComponent();
        }
        public LendForm(bool lendMode, int bookIndex, int readerIndex)
        {
            this.lendMode = lendMode;
            InitializeComponent();
            if (lendMode)
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
                BookTableForm.AllBookStorage.to_beginning();
                savedBook = BookTableForm.AllBookStorage.getData();
                LoadSavedBook();
                bookChoosen = true;
                //make ChooseBookButton visible
                //MoreBookButton - invisible
            }
            else
            {
                savedBook = BookTableForm.AllBookStorage.FindById(bookIndex);
                LoadSavedBook();
                bookChoosen = true;
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
                readerChoosen = true;
            }


        }
        //for loading book from code to form
        private void LoadSavedBook()
        {
            BookIndexTextBox.Text = savedBook.id.ToString();
            BookNameTextBox.Text = savedBook.name.ToString();
        }

        //for saving book from form to code
        /*private void SaveBook()
        {
            savedBook.id = Int32.Parse(BookIndexTextBox.Text);
            savedBook.name = BookNameTextBox.Text;
        }*/

        //Из формы копируется только две характеристики, этот метод не имеет смысла
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

        private void LendButton_Click(object sender, EventArgs e)
        {
            if (!bookChoosen)
            {
                MessageBox.Show("Выберите книгу");
                return;
            }
            if (!readerChoosen)
            {
                MessageBox.Show("Выберите читателя");
                return;
            }
            if (lendMode)
            {
                if (savedBook.amount <= 0)
                {
                    MessageBox.Show("Экземпляров этой книги нет в хранилище.\nНевозможно выдать.");
                    return;
                }

                FileStream fs = new FileStream(pathToDB_takenBooks, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                string line = Convert.ToInt32(lendMode).ToString() + ' ' + savedBook.id.ToString("D" + 6) + ' ' + savedReader[0]
                    + ' ' + DateTime.Now.ToString().Substring(0, 10);
                sw.WriteLine(line);
                sw.Flush();
                Debug.WriteLine(line);
                fs.Close();
                savedBook.amount = savedBook.amount - 1;
                MessageBox.Show("Книга выдана.");
            }
            else
            {
                FileStream fs = new FileStream(pathToDB_takenBooks, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string[] line = new string[4];
                int founded = 0;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine().Split(' ');
                    if (Convert.ToBoolean(Int32.Parse(line[0])) == true && Int32.Parse(line[1]) == savedBook.id && line[2] == savedReader[0])
                    {
                        //match
                        founded++;

                    }
                    if (Convert.ToBoolean(Int32.Parse(line[0])) == false && Int32.Parse(line[1]) == savedBook.id && line[2] == savedReader[0])
                    {
                        //match
                        founded--;

                    }
                }
                fs.Close();
                if (founded > 0)
                {
                    fs = new FileStream(pathToDB_takenBooks, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    string lineSW = Convert.ToInt32(lendMode).ToString() + ' ' + savedBook.id.ToString("D" + 6) + ' ' + savedReader[0]
                    + ' ' + DateTime.Now.ToString().Substring(0, 10);
                    sw.WriteLine(lineSW);
                    sw.Flush();
                    fs.Close();
                    MessageBox.Show("Книга принята");
                }
                else
                {
                    MessageBox.Show("Запись о выдаче данной книги не найдена в БД.\nПрием невозможен.");
                    return;
                }


            }
        }
        void Update()
        {
            //update data from DB by indexes in ReaderIndexTextBox and BookIndexTextBox
        }

        private void ChooseReaderButton_Click(object sender, EventArgs e)
        {
            ReadersTableForm frm = new ReadersTableForm(true);
            DialogResult res = frm.ShowDialog();
            FileStream fs = new FileStream(pathToDB_readers, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(' ');

                if (Int32.Parse(line[0]) == (int)res)
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
            readerChoosen = true;
        }

        private void MoreReaderButton_Click(object sender, EventArgs e)
        {
            if (!readerChoosen)
            {
                MessageBox.Show("Выберите читателя");
                return;
            }
            ReaderForm readerForm = new ReaderForm(Int32.Parse(savedReader[0]));
            readerForm.ShowDialog();
        }

        private void ChooseBookButton_Click(object sender, EventArgs e)
        {

            DialogResult res = bookTableForm.ShowDialog();
            savedBook = BookTableForm.AllBookStorage.FindById((int)res);
            LoadSavedBook();
        }

        private void MoreBookButton_Click(object sender, EventArgs e)
        {
            if (!bookChoosen)
            {
                MessageBox.Show("Выберите книгу");
                return;
            }
            BookForm bookForm = new BookForm(savedBook.id, savedBook);
            bookForm.ShowDialog();
        }
    }
}
