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
using System.Drawing.Printing;

namespace biblaoteka
{
    public partial class MainForm : Form
    {
        public static BookTableForm bookTableForm = new BookTableForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("going to BookTableForm");
            this.Hide();
            bookTableForm.ShowDialog();
            this.Show();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("going to AddBookForm");
            this.Hide();
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
            this.Show();
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
            int xA = Width / 3, xB = Width * 2 / 3, xC = Width, y = Height;
            int recWidth = Width / 3, recHeight = Height;
            Rectangle recA = new Rectangle(0, 0, recWidth, recHeight);
            Rectangle recB = new Rectangle(xA, 0, recWidth, recHeight);
            Rectangle recC = new Rectangle(xB, 0, recWidth, recHeight);
            Debug.WriteLine(recA.ToString());
            Debug.WriteLine(recB.ToString());
            Debug.WriteLine(recC.ToString());
            Color colorA = ColorTranslator.FromHtml("#89B5B9");
            Color colorB = ColorTranslator.FromHtml("#8BA55F");
            Color colorC = ColorTranslator.FromHtml("#C46560");
            Brush brushA = new SolidBrush(colorA);
            Brush brushB = new SolidBrush(colorB);
            Brush brushC = new SolidBrush(colorC);

            e.Graphics.FillRectangle(brushA, recA);
            e.Graphics.FillRectangle(brushB, recB);
            e.Graphics.FillRectangle(brushC, recC);

            int gradientRecWidth = recWidth / 3, gradientRecHeight = recHeight;
            Rectangle gradientRecAB = new Rectangle(xA * 7 / 8, 0, gradientRecWidth, gradientRecHeight);
            Brush brushAB = new LinearGradientBrush(gradientRecAB, colorA, colorB, 0.01f);
            e.Graphics.FillRectangle(brushAB, gradientRecAB);
            Debug.WriteLine(gradientRecAB.ToString());

            Rectangle gradientRecBC = new Rectangle(xB * 15 / 16, 0, gradientRecWidth, gradientRecHeight);
            Brush brushBC = new LinearGradientBrush(gradientRecBC, colorB, colorC, 0.01f);
            e.Graphics.FillRectangle(brushBC, gradientRecBC);
            Debug.WriteLine(gradientRecBC.ToString());
        }
    }
}
