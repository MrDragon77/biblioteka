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
        FileStream fs;
        public ReadersTableForm()
        {
            InitializeComponent();
            fs = new FileStream(pathToDB, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            readers = new List<Reader>();
            ReadReadersFromDB();
            FillTable();
        }
        bool ReadReadersFromDB()
        {
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
                    return false;
                }
            }
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

    }
}
