using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace biblaoteka
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("going to BookTableForm");
            this.Close();
            BookTableForm bookTableForm = new BookTableForm();
            bookTableForm.Show();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("going to AddBookForm");
            this.Close();
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void ReadersButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("going to ReadersForm");
            this.Close();
            ReadersTableForm readersForm = new ReadersTableForm();
            readersForm.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm authForm = new AuthorizationForm();
            authForm.Show();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            int xA = Width / 3, xB = Width / 3 * 2, xC = Width, y = Height;
            Rectangle recA = new Rectangle(0, 0, xA, y);
            Rectangle recB = new Rectangle(xA, 0, xB, y);
            Rectangle recC = new Rectangle(xB, 0, xC, y);

            Brush brushA = new SolidBrush(Color.LightBlue);
            Brush brushB = new SolidBrush(Color.LawnGreen);
            Brush brushC = new SolidBrush(ColorTranslator.FromHtml("#D95143"));

            e.Graphics.FillRectangle(brushA, recA);
            e.Graphics.FillRectangle(brushB, recB);
            e.Graphics.FillRectangle(brushC, recC);
        }
    }
}
