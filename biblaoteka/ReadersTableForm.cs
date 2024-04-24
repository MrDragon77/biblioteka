using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblaoteka
{
    public partial class ReadersTableForm : Form
    {
        string pathToDB = "Readers.txt";
        List<Reader> readers;
        public ReadersTableForm()
        {
            InitializeComponent();
            readers = new List<Reader>();
            ReadReadersFromDB();
            FillTable();
        }
        //void CreateFileStream()
        //{
        //    fs = new FileStream(pathToDB, FileMode.Open, FileAccess.ReadWrite);
        //}
        bool ReadReadersFromDB()
        {
            FileStream fs = new FileStream(pathToDB, FileMode.Open, FileAccess.Read);
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
            File.Copy(pathToDB, "tmp.txt");
            FileStream fs2 = new FileStream("tmp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs2);
            FileStream fs = new FileStream(pathToDB, FileMode.Truncate, FileAccess.Write);
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
            return true;
        }
        void FillTable()
        {
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
            ReaderForm readerForm = new ReaderForm(index);
            readerForm.ShowDialog();
        }
    }
}
