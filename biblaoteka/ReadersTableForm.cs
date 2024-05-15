using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblaoteka
{
    public partial class ReadersTableForm : Form
    {
        string pathToDB_Readers = "Readers.txt";
        string pathToDB_TakenBooks = "TakenBooks.txt";
        List<Reader> readers;
        bool lendMode = false; //use true for open ReadersTable in choosing reader mode for LendForm
        public ReadersTableForm()
        {
            InitializeComponent();
            readers = new List<Reader>();
            //FixAmountTakenBooksDB();
            //ReadReadersFromDB();
            //FillTable();
            UpdateDB();
        }
        public ReadersTableForm(bool lendMode)
        {
            this.lendMode = lendMode;
            InitializeComponent();
            readers = new List<Reader>();
            //FixAmountTakenBooksDB();
            //ReadReadersFromDB();
            //FillTable();
            UpdateDB();
        }
        //void CreateFileStream()
        //{
        //    fs = new FileStream(pathToDB, FileMode.Open, FileAccess.ReadWrite);
        //}
        bool ReadReadersFromDB()
        {
            readers.Clear();
            FileStream fs = new FileStream(pathToDB_Readers, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(' ');
                try
                {
                    readers.Add(new Reader(Int32.Parse(line[0]), line[1], line[2], line[3], DateTime.Parse(line[4]), Int32.Parse(line[5])));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex.Message);
                    fs.Close();
                    return false;
                }
            }
            fs.Close();
            return true;
        }
        bool FixIndexesDB()
        {
            File.Copy(pathToDB_Readers, "tmp.txt");
            FileStream fs2 = new FileStream("tmp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs2);
            FileStream fs = new FileStream(pathToDB_Readers, FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);


            int index = 1;
            int indexLen = 6;
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] line = sr.ReadLine().Split(' ');
                    sw.WriteLine(index.ToString("D" + indexLen) + ' ' + line[1] + ' ' + line[2] + ' ' + line[3] + ' ' + line[4] + ' ' + line[5]);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex.Message);
                    fs.Close();
                    fs2.Close();
                    return false;
                }
                index++;
            }
            sw.Flush();
            fs.Close();
            fs2.Close();
            File.Delete("tmp.txt");
            //MessageBox.Show("fixed indexes");
            Debug.WriteLine("fixed indexes");
            return true;
        }
        bool FixAmountTakenBooksDB()
        {

            FileStream fs2 = new FileStream(pathToDB_Readers, FileMode.Open, FileAccess.Read);
            StreamReader sr2 = new StreamReader(fs2);
            string[] lineReader = new string[6];
            string[] lineTakenBooks = new string[4];
            List<int> amounts = new List<int>();

            while (!sr2.EndOfStream)
            {
                lineReader = sr2.ReadLine().Split(' ');

                List<int> TakenBooksIndexes = new List<int>();

                FileStream fsIn = new FileStream(pathToDB_TakenBooks, FileMode.Open, FileAccess.Read);
                StreamReader sr1 = new StreamReader(fsIn);
                while (!sr1.EndOfStream)
                {
                    lineTakenBooks = sr1.ReadLine().Split(' ');
                    if (lineTakenBooks[2] == lineReader[0])
                    {

                        if (Int32.Parse(lineTakenBooks[0]) == 1)
                        {
                            TakenBooksIndexes.Add(Int32.Parse(lineTakenBooks[1]));
                        }
                        if (Int32.Parse(lineTakenBooks[0]) == 0)
                        {
                            int removeIndex = TakenBooksIndexes.IndexOf(Int32.Parse(lineTakenBooks[1]));
                            Debug.WriteLine("index: ", removeIndex);
                            TakenBooksIndexes.RemoveAt(removeIndex);
                        }
                    }
                }
                fsIn.Close();
                amounts.Add(TakenBooksIndexes.Count);
            }
            fs2.Close();

            File.Copy(pathToDB_Readers, "tmp.txt");
            fs2 = new FileStream("tmp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs2);
            FileStream fs1 = new FileStream(pathToDB_Readers, FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);

            int i = 0;
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] line = sr.ReadLine().Split(' ');
                    sw.WriteLine(line[0] + ' ' + line[1] + ' ' + line[2] + ' ' + line[3] + ' ' + line[4] + ' ' + amounts[i]);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex.Message);
                    fs1.Close();
                    fs2.Close();
                    return false;
                }
                i++;
            }
            sw.Flush();
            fs1.Close();
            fs2.Close();
            File.Delete("tmp.txt");
            //MessageBox.Show("fixed amount of taken books");
            Debug.WriteLine("fixed amount of taken books");
            return true;

        }
        void FillTable()
        {
            ReadersTableDataGridView.Rows.Clear();
            for (int i = 0; i < readers.Count(); i++)
            {
                DataGridViewCell tb_index = new DataGridViewTextBoxCell();
                tb_index.Value = readers[i].index.ToString();
                DataGridViewCell tb_fullName = new DataGridViewTextBoxCell();
                tb_fullName.Value = readers[i].fam + ' ' + readers[i].name + ' ' + readers[i].ot;
                DataGridViewCell tb_birthDate = new DataGridViewTextBoxCell();
                tb_birthDate.Value = readers[i].birthDate.Date.ToString().Substring(0, 10);
                DataGridViewCell tb_amountTakenBooks = new DataGridViewTextBoxCell();
                tb_amountTakenBooks.Value = readers[i].amountTakenBooks.ToString();

                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(tb_index, tb_fullName, tb_birthDate, tb_amountTakenBooks);
                ReadersTableDataGridView.Rows.Add(row);
            }

        }
        void UpdateDB()
        {
            FixIndexesDB();
            FixAmountTakenBooksDB();
            ReadReadersFromDB();
            FillTable();
        }

        private void fixbutton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(FixIndexesDB());
        }

        private void ReadersTableDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = ReadersTableDataGridView.SelectedCells[0].RowIndex;
            //string index = ReadersTableDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            int index = Int32.Parse(ReadersTableDataGridView[0, rowIndex].Value.ToString());
            Debug.WriteLine(rowIndex);
            Debug.WriteLine(index);
            if (lendMode)
            {
                this.DialogResult = (DialogResult)index;
            }
            else
            {
                ReaderForm readerForm = new ReaderForm(index);
                readerForm.ShowDialog();
            }
            UpdateDB();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void NewReaderButton_Click(object sender, EventArgs e)
        {
            ReaderForm readerForm = new ReaderForm();
            readerForm.ShowDialog();
            //ReadReadersFromDB();
            //FillTable();
            UpdateDB();
        }
    }
}
