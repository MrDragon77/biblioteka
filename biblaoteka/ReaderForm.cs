using System;
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
        string pathToDB = "Readers.txt";
        string[] savedReader;
        public ReaderForm()
        {
            InitializeComponent();
        }
        public ReaderForm(int index)
        {
            InitializeComponent();
            FileStream fs = new FileStream(pathToDB, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(' ');

                if (Int32.Parse(line[0]) == index)
                {
                    savedReader = new string[4];
                    savedReader[0] = line[0];
                    savedReader[1] = line[1] + ' ' + line[2] + ' ' + line[3];
                    savedReader[2] = line[4];
                    savedReader[3] = line[5];
                }
            }
            LoadSavedReader();
            SaveChangesButton.Visible = false;
            DiscardChangesButton.Visible = false;
            fs.Close();
        }
        private void LoadSavedReader()
        {
            ReaderIndexTextBox.Text = savedReader[0];
            ReaderFullNameTextBox.Text = savedReader[1];
            ReaderBirthDateTextBox.Text = savedReader[2];
            ReaderAmountTakenBooksTextBox.Text = savedReader[3];
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
                MessageBox.Show("It must contain 3 things: fam, name, ot. Divided by space symbol.\nIf reader does not have ot plase - instead of it.", "Wrong Full Name");
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
                MessageBox.Show("It must contain birth date in dd.mm.yyyy format.", "Wrong Birth Date");
                return;
            }
            
            //data good, can write to DB

            string[] readerstxt = File.ReadAllLines(pathToDB);
            //for (int i = 0; i < readerstxt.Length; i++)
            //{
            //    Debug.WriteLine(readerstxt[i]);
            //}
            int searchIndex = 0;
            bool founded = false;
            for(int i = 0;  i < readerstxt.Length; i++)
            {
                string[] line = readerstxt[i].Split(' ');
                if (Int32.Parse(line[0]) == Int32.Parse(ReaderIndexTextBox.Text))
                {
                    searchIndex = i;
                    founded = true;
                    break;
                }
            }
            if(!founded)
            {
                Debug.WriteLine("index not found");
                return;
            }
            FileStream fs = new FileStream(pathToDB, FileMode.Truncate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for(int i = 0; i < searchIndex; i++)
            {
                sw.WriteLine(readerstxt[i]);
            }
            sw.WriteLine(ReaderIndexTextBox.Text + ' ' + ReaderFullNameTextBox.Text + ' ' + ReaderBirthDateTextBox.Text + ' ' + ReaderAmountTakenBooksTextBox.Text);
            for (int i = searchIndex+1; i < readerstxt.Length; i++)
            {
                sw.WriteLine(readerstxt[i]);
            }
            sw.Flush();
            fs.Close();
        }

        private void DiscardChangesButton_Click(object sender, EventArgs e)
        {
            LoadSavedReader();
        }
    }
}
