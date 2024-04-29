using Books;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace biblaoteka
{
    public partial class BookTableForm : Form
    {
        public static MyBookStorage<Book> AllBookStorage = new MyBookStorage<Book>();
        MyBookStorage<Book> CurBookStorage = new MyBookStorage<Book>();
        public static int book_id = 4;
        Book book1 = new Book("Война и мир", "Толстой", "Москва 2010", 1, 14, 1);
        Book book2 = new Book("Ревизор", "Гоголь", "Москва 2010", 2, 3, 2);
        Book book3 = new Book("Сумерки", "Я не помню...", "Уфа 2024", 3, 42, 3);
        void CreateTable()
        {
            /*размер таблицы*/
            BookDataGV.Size = new Size(400, 200);

            /*создание столбцов*/
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "id";
            column0.HeaderText = "Id";
            //1 столбец, название
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "name";
            column1.HeaderText = "Название";
            //2 столбец, автор
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "author";
            column2.HeaderText = "Автор";
            //3 столбец, издательство
            DataGridViewImageColumn column3 = new DataGridViewImageColumn();
            column3.Name = "isd";
            column3.HeaderText = "Издательство";
            //4 столбец, жанр
            DataGridViewImageColumn column4 = new DataGridViewImageColumn();
            column4.Name = "genre";
            column4.HeaderText = "Жанр";
            //5 столбец, количество экземпляров
            DataGridViewImageColumn column5 = new DataGridViewImageColumn();
            column5.Name = "amount";
            column5.HeaderText = "Количество";
            //добавляем столбцы
            BookDataGV.Columns.AddRange(column0, column1, column2, column3, column4, column5);
        }
        public string IntToGenre(int genre)
        {
            switch (genre)
            {
                case 1:
                    return "Роман";
                case 2:
                    return "Комедия";
                case 3:
                    return "Драма";
            }
            return "Неизвестен";
        }

        public int GenreToInt(string genre)
        {
            switch (genre)
            {
                case "Роман":
                    return 1;
                case "Комедия":
                    return 2;
                case "Драма":
                    return 3;
            }
            return 0;
        }

        void FillTable(MyBookStorage<Book> bookStorage)
        {

            /*создание ячеек*/
            bookStorage.to_beginning();
            for (int i = 0; i < bookStorage.size(); i++)
            {
                DataGridViewCell tb_id = new DataGridViewTextBoxCell();
                DataGridViewCell tb_name = new DataGridViewTextBoxCell();
                DataGridViewCell tb_author = new DataGridViewTextBoxCell();
                DataGridViewCell tb_isd = new DataGridViewTextBoxCell();
                DataGridViewCell tb_genre = new DataGridViewTextBoxCell();
                DataGridViewCell tb_amount = new DataGridViewTextBoxCell();
                tb_id.Value = bookStorage.getData().id;
                tb_name.Value = bookStorage.getData().name;
                tb_author.Value = bookStorage.getData().author;
                tb_isd.Value = bookStorage.getData().isd;
                tb_genre.Value = IntToGenre(bookStorage.getData().genre);
                tb_amount.Value = bookStorage.getData().amount;
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(tb_id, tb_name, tb_author, tb_isd, tb_genre, tb_amount);
                BookDataGV.Rows.Add(row);
                bookStorage.next();
            }
        }
        public BookTableForm()
        {
            AllBookStorage.push_back(book1);
            AllBookStorage.push_back(book2);
            AllBookStorage.push_back(book3);
            CurBookStorage = AllBookStorage;
            InitializeComponent();
            GenreComboBox.SelectedIndex = 0;
            MethodComboBox.SelectedIndex = 0;
            // CreateTable();
            FillTable(AllBookStorage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {

            if (MethodComboBox.SelectedIndex == 0)
            {
                MyBookStorage<Book> sorted_books = CurBookStorage.FindByName(FindBox.Text);
                BookDataGV.Rows.Clear();
                FillTable(sorted_books);
            }
            else
            {
                if (MethodComboBox.SelectedIndex == 1)
                {
                    MyBookStorage<Book> sorted_books = CurBookStorage.FindByAuthor(FindBox.Text);
                    BookDataGV.Rows.Clear();
                    FillTable(sorted_books);
                }
                else
                {
                    if (MethodComboBox.SelectedIndex == 2)
                    {
                        MyBookStorage<Book> sorted_books = CurBookStorage.FindByIsd(FindBox.Text);
                        BookDataGV.Rows.Clear();
                        FillTable(sorted_books);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GenreComboBox_DropDownClosed(object sender, EventArgs e)
        {
            CurBookStorage = AllBookStorage.FindByGenre(GenreComboBox.SelectedIndex);
            BookDataGV.Rows.Clear();
            FillTable(CurBookStorage);
        }

        private void AddNewBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
            this.Show();
            GenreComboBox_DropDownClosed(sender, e);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (BookDataGV.SelectedRows.Count != 0)
            {
                for (int i = 0; i < BookDataGV.SelectedRows.Count; i++)
                {
                    Book dltBook = new Book(BookDataGV.SelectedRows[i].Cells[1].Value.ToString(),
                        BookDataGV.SelectedRows[i].Cells[2].Value.ToString(),
                        BookDataGV.SelectedRows[i].Cells[3].Value.ToString(),
                        GenreToInt(BookDataGV.SelectedRows[i].Cells[4].Value.ToString()),
                        Convert.ToInt32(BookDataGV.SelectedRows[i].Cells[5].Value));

                    if (AllBookStorage.Find(dltBook))
                    {
                        // Я тут просто копировал удаляемую книгу, тем самым выводя что я там накопировал, во такой вот дебаг метод смешной

                        /*DataGridViewRow row = new DataGridViewRow();
                        DataGridViewCell tb_name = new DataGridViewTextBoxCell();
                        DataGridViewCell tb_author = new DataGridViewTextBoxCell();
                        DataGridViewCell tb_isd = new DataGridViewTextBoxCell();
                        DataGridViewCell tb_genre = new DataGridViewTextBoxCell();
                        DataGridViewCell tb_amount = new DataGridViewTextBoxCell();
                        tb_name.Value = dltBook.name;
                        tb_author.Value = dltBook.author;
                        tb_isd.Value = dltBook.isd;
                        tb_genre.Value = IntToGenre(dltBook.genre);
                        tb_amount.Value = dltBook.amount;
                        DataGridViewRow row1 = new DataGridViewRow();
                        row1.Cells.AddRange(tb_name, tb_author, tb_isd, tb_genre, tb_amount);
                        BookDataGV.Rows.Add(row1);*/
                        AllBookStorage.DeleteCurrent();
                        CurBookStorage.Find(dltBook);
                        CurBookStorage.DeleteCurrent();
                        GenreComboBox_DropDownClosed(sender, e);
                    }

                }

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = saveFileDialog.FileName;

            StreamWriter file = new StreamWriter(filename);
            file.WriteLine("Книги: ");
            file.WriteLine(AllBookStorage.size().ToString());
            AllBookStorage.to_beginning();
            AllBookStorage.getData().Save(file);
            while (AllBookStorage.next())
            {
                AllBookStorage.getData().Save(file);
            }
            file.Close();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = openFileDialog.FileName;

            StreamReader file = new StreamReader(filename);
            string type = file.ReadLine();
            if (type != "Книги: ")
            {
                file.Close();
                MessageBox.Show("Некорректный файл. Попробуйте указать другой файл.");
                return;
            }

            while (AllBookStorage.size() > 0)
            {
                AllBookStorage.DeleteCurrent();
            }
            book_id = 1;
            int numOfElems = Int32.Parse(file.ReadLine());
            for (int i = 0; i < numOfElems; ++i)
            {
                Book elem = new Book();
                elem.Load(file);
                AllBookStorage.push_back(elem);
            }
            book_id = AllBookStorage.getData().id + 1;
            GenreComboBox_DropDownClosed(sender, e);
            file.Close();
        }

        private void BookDataGV_DoubleClick(object sender, EventArgs e)
        {
            int rowIndex = BookDataGV.SelectedCells[0].RowIndex;
            //string index = ReadersTableDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            int index = Int32.Parse(BookDataGV[0, rowIndex].Value.ToString());
            Debug.WriteLine(rowIndex);
            Debug.WriteLine(index);
            Book selected_book = new Book(BookDataGV.Rows[rowIndex].Cells[1].Value.ToString(),
                        BookDataGV.Rows[rowIndex].Cells[2].Value.ToString(),
                        BookDataGV.Rows[rowIndex].Cells[3].Value.ToString(),
                        GenreToInt(BookDataGV.Rows[rowIndex].Cells[4].Value.ToString()),
                        Convert.ToInt32(BookDataGV.Rows[rowIndex].Cells[5].Value));
            BookForm bookForm = new BookForm(index, selected_book);
            bookForm.ShowDialog();
            GenreComboBox_DropDownClosed(sender, e);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}