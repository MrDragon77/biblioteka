﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblaoteka
{

    public partial class ReaderForm : Form
    {
        string pathToDB_Readers = "Readers.txt";
        string pathToDB_TakenBooks = "TakenBooks.txt";
        string[] savedReader = new string[4];
        public ReaderForm()
        {
            InitializeComponent();
            FileStream fs = new FileStream(pathToDB_Readers, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = "000000";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
            }
            string[] dividedLine = line.Split(' ');
            int newIndex = int.Parse(dividedLine[0]) + 1;
            int indexLen = 6;
            ReaderIndexTextBox.Text = newIndex.ToString("D" + indexLen);
            ReaderAmountTakenBooksTextBox.Text = "0";
            SaveReader();
            fs.Close();
        }
        public ReaderForm(int index)
        {
            InitializeComponent();
            FileStream fs = new FileStream(pathToDB_Readers, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(' ');

                if (Int32.Parse(line[0]) == index)
                {
                    savedReader[0] = line[0];
                    savedReader[1] = line[1] + ' ' + line[2] + ' ' + line[3];
                    savedReader[2] = line[4];
                    savedReader[3] = line[5];
                }
            }
            LoadSavedReader();
            SaveChangesButton.Visible = false;
            DiscardChangesButton.Visible = false;
            FillTakenBooksTable();
            fs.Close();
        }
        private void FillTakenBooksTable()
        {
            FileStream fs = new FileStream(pathToDB_TakenBooks, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string[] line = new string[4];
            //List<int> TakenBooks_Indexes = new List<int>();
            List<int> TakenBooksIndexes = new List<int>();
            List<string> TakenBooksDates = new List<string>();
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine().Split(' ');
                //index reader


                if (line[2] == savedReader[0])
                {
                    //string[] toAdd = new string[2];
                    //toAdd[0] = line[1];
                    //toAdd[1] = line[3];
                    //Debug.WriteLine(toAdd[0]);
                    //Debug.WriteLine(toAdd[1]);
                    if (Int32.Parse(line[0]) == 1)
                    {
                        TakenBooksIndexes.Add(Int32.Parse(line[1]));
                        TakenBooksDates.Add(line[3]);
                    }
                    if (Int32.Parse(line[0]) == 0)
                    {
                        int removeIndex = TakenBooksIndexes.IndexOf(Int32.Parse(line[1]));
                        Debug.WriteLine("index: ", removeIndex);
                        TakenBooksIndexes.RemoveAt(removeIndex);
                        TakenBooksDates.RemoveAt(removeIndex);
                    }
                    //сделал через костыль и 2 массива xd
                    //не осуждайте
                }
            }
            fs.Close();
            for (int i = 0; i < TakenBooksIndexes.Count; i++)
            {
                Debug.WriteLine(TakenBooksIndexes[i], " ");
                Debug.WriteLine(TakenBooksDates[i], " ");

                Books.Book book = BookTableForm.AllBookStorage.FindById(TakenBooksIndexes[i]);
                DataGridViewCell tb_index = new DataGridViewTextBoxCell();
                tb_index.Value = book.id.ToString();
                DataGridViewCell tb_BookName = new DataGridViewTextBoxCell();
                tb_BookName.Value = book.name.ToString();
                DataGridViewCell tb_takenDate = new DataGridViewTextBoxCell();
                tb_takenDate.Value = TakenBooksDates[i];
                DataGridViewCell tb_returnDate = new DataGridViewTextBoxCell();
                tb_returnDate.Value = DateTime.ParseExact(TakenBooksDates[i], "dd.MM.yyyy", CultureInfo.InvariantCulture).AddDays(book.GenreToReturnDate()).ToString().Substring(0, 10); //need to change to return date by жанр

                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(tb_index, tb_BookName, tb_takenDate, tb_returnDate);
                TakenBooksDataGridView.Rows.Add(row);
            }

        }
        private void LoadSavedReader()
        {
            ReaderIndexTextBox.Text = savedReader[0];
            ReaderFullNameTextBox.Text = savedReader[1];
            ReaderBirthDateTextBox.Text = savedReader[2];
            ReaderAmountTakenBooksTextBox.Text = savedReader[3];
        }
        private void SaveReader()
        {
            savedReader[0] = ReaderIndexTextBox.Text;
            savedReader[1] = ReaderFullNameTextBox.Text;
            savedReader[2] = ReaderBirthDateTextBox.Text;
            savedReader[3] = ReaderAmountTakenBooksTextBox.Text;
        }

        private void ReaderFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveChangesButton.Visible = true;
            DiscardChangesButton.Visible = true;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            string[] fullName = ReaderFullNameTextBox.Text.ToString().Split(' ');
            if (fullName.Length != 3)
            {
                MessageBox.Show("Поле должно содержать ФИО: фамилию, имя, отчество. Каждый должен быть разделен пробелом.\nЕсли какой-то из параметров, например имя, содержит пробел, замените его на нижнее подчеркивание - '_'\nЕсли читатель не имеет имени или фамилии, замените его на дефис '-'.", "Неправильное ФИО");
                return;
            }
            try
            {
                DateTime birthDate = DateTime.ParseExact(ReaderBirthDateTextBox.Text, "dd.mm.yyyy", CultureInfo.InvariantCulture);
                if (birthDate > DateTime.Now)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
                MessageBox.Show("Поле должно содержать дату рождения в формате dd.mm.yyyy", "Неправильная дата рождения");
                return;
            }

            //data good, can write to DB

            string[] readerstxt = File.ReadAllLines(pathToDB_Readers);
            //for (int i = 0; i < readerstxt.Length; i++)
            //{
            //    Debug.WriteLine(readerstxt[i]);
            //}
            int searchIndex = 0;
            bool founded = false;
            string[] line = { "0" };
            for (int i = 0; i < readerstxt.Length; i++)
            {
                line = readerstxt[i].Split(' ');
                if (Int32.Parse(line[0]) == Int32.Parse(ReaderIndexTextBox.Text))
                {
                    searchIndex = i;
                    founded = true;
                    break;
                }
            }
            if (!founded)
            {
                searchIndex = readerstxt.Length;
                Debug.WriteLine("index not found, creating new one");
            }
            FileStream fs = new FileStream(pathToDB_Readers, FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < searchIndex; i++)
            {
                sw.WriteLine(readerstxt[i]);
            }
            sw.WriteLine(ReaderIndexTextBox.Text + ' ' + ReaderFullNameTextBox.Text + ' ' + ReaderBirthDateTextBox.Text + ' ' + ReaderAmountTakenBooksTextBox.Text);
            for (int i = searchIndex + 1; i < readerstxt.Length; i++)
            {
                sw.WriteLine(readerstxt[i]);
            }
            sw.Flush();
            fs.Close();

            SaveReader();
            SaveChangesButton.Visible = false;
            DiscardChangesButton.Visible = false;
        }

        private void DiscardChangesButton_Click(object sender, EventArgs e)
        {
            LoadSavedReader();
            SaveChangesButton.Visible = false;
            DiscardChangesButton.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToLendButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LendForm lendForm = new LendForm(true, 0, Int32.Parse(savedReader[0]));
            lendForm.ShowDialog();
            this.Show();
        }

        private void ToReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            int bookIndex = 0;
            if (TakenBooksDataGridView.RowCount > 0)
            {
                int rowIndex = TakenBooksDataGridView.SelectedCells[0].RowIndex;
                bookIndex = Int32.Parse(TakenBooksDataGridView[0, rowIndex].Value.ToString());
            }
            LendForm lendForm = new LendForm(false, bookIndex, Int32.Parse(savedReader[0]));
            lendForm.ShowDialog();
            this.Show();
        }
    }
}
