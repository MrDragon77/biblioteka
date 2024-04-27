using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace biblaoteka
{
    partial class BookTableForm : Form
    {


        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTableForm));
            BookDataGV = new DataGridView();
            IdClmn = new DataGridViewTextBoxColumn();
            NameClmn = new DataGridViewTextBoxColumn();
            AuthorClmn = new DataGridViewTextBoxColumn();
            IsdClmn = new DataGridViewTextBoxColumn();
            GenreClmn = new DataGridViewTextBoxColumn();
            AmountClmn = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            MethodComboBox = new ToolStripComboBox();
            FindBox = new ToolStripTextBox();
            FindButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            GenreComboBox = new ToolStripComboBox();
            AddNewBox = new ToolStripButton();
            DeleteBtn = new ToolStripButton();
            SaveBtn = new ToolStripButton();
            LoadBtn = new ToolStripButton();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)BookDataGV).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BookDataGV
            // 
            BookDataGV.AllowUserToAddRows = false;
            BookDataGV.AllowUserToDeleteRows = false;
            BookDataGV.BackgroundColor = SystemColors.ActiveCaption;
            BookDataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDataGV.Columns.AddRange(new DataGridViewColumn[] { IdClmn, NameClmn, AuthorClmn, IsdClmn, GenreClmn, AmountClmn });
            BookDataGV.Location = new Point(0, 19);
            BookDataGV.Margin = new Padding(3, 2, 3, 2);
            BookDataGV.Name = "BookDataGV";
            BookDataGV.ReadOnly = true;
            BookDataGV.RowHeadersWidth = 51;
            BookDataGV.RowTemplate.Height = 29;
            BookDataGV.Size = new Size(700, 319);
            BookDataGV.TabIndex = 0;
            // 
            // IdClmn
            // 
            IdClmn.HeaderText = "Id книги";
            IdClmn.MinimumWidth = 6;
            IdClmn.Name = "IdClmn";
            IdClmn.ReadOnly = true;
            IdClmn.Width = 125;
            // 
            // NameClmn
            // 
            NameClmn.HeaderText = "Название";
            NameClmn.MinimumWidth = 6;
            NameClmn.Name = "NameClmn";
            NameClmn.ReadOnly = true;
            NameClmn.Width = 125;
            // 
            // AuthorClmn
            // 
            AuthorClmn.HeaderText = "Автор";
            AuthorClmn.MinimumWidth = 6;
            AuthorClmn.Name = "AuthorClmn";
            AuthorClmn.ReadOnly = true;
            AuthorClmn.Width = 125;
            // 
            // IsdClmn
            // 
            IsdClmn.HeaderText = "Издание";
            IsdClmn.MinimumWidth = 6;
            IsdClmn.Name = "IsdClmn";
            IsdClmn.ReadOnly = true;
            IsdClmn.Width = 125;
            // 
            // GenreClmn
            // 
            GenreClmn.HeaderText = "Жанр";
            GenreClmn.MinimumWidth = 6;
            GenreClmn.Name = "GenreClmn";
            GenreClmn.ReadOnly = true;
            GenreClmn.Width = 125;
            // 
            // AmountClmn
            // 
            AmountClmn.HeaderText = "Количество";
            AmountClmn.MinimumWidth = 6;
            AmountClmn.Name = "AmountClmn";
            AmountClmn.ReadOnly = true;
            AmountClmn.Width = 125;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Teal;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { MethodComboBox, FindBox, FindButton, toolStripSeparator1, GenreComboBox, AddNewBox, DeleteBtn, SaveBtn, LoadBtn });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(700, 28);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // MethodComboBox
            // 
            MethodComboBox.BackColor = SystemColors.HighlightText;
            MethodComboBox.ForeColor = SystemColors.InactiveCaptionText;
            MethodComboBox.Items.AddRange(new object[] { "Назвние", "Автор", "Издание" });
            MethodComboBox.Name = "MethodComboBox";
            MethodComboBox.Size = new Size(88, 28);
            // 
            // FindBox
            // 
            FindBox.AutoSize = false;
            FindBox.BackColor = SystemColors.InactiveCaption;
            FindBox.BorderStyle = BorderStyle.FixedSingle;
            FindBox.Name = "FindBox";
            FindBox.Size = new Size(132, 23);
            // 
            // FindButton
            // 
            FindButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FindButton.Image = (Image)resources.GetObject("FindButton.Image");
            FindButton.ImageTransparentColor = Color.Magenta;
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(24, 25);
            FindButton.Text = "toolStripButton1";
            FindButton.Click += FindButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // GenreComboBox
            // 
            GenreComboBox.Items.AddRange(new object[] { "Любой жанр", "Роман", "Комедия ", "Драма" });
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(106, 28);
            GenreComboBox.DropDownClosed += GenreComboBox_DropDownClosed;
            // 
            // AddNewBox
            // 
            AddNewBox.AutoSize = false;
            AddNewBox.BackColor = Color.MediumSeaGreen;
            AddNewBox.DisplayStyle = ToolStripItemDisplayStyle.Text;
            AddNewBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddNewBox.Image = (Image)resources.GetObject("AddNewBox.Image");
            AddNewBox.ImageTransparentColor = Color.Magenta;
            AddNewBox.Name = "AddNewBox";
            AddNewBox.Size = new Size(85, 25);
            AddNewBox.Text = "Добавить";
            AddNewBox.Click += AddNewBox_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.AutoSize = false;
            DeleteBtn.BackColor = Color.Firebrick;
            DeleteBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            DeleteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.Image = (Image)resources.GetObject("DeleteBtn.Image");
            DeleteBtn.ImageTransparentColor = Color.Magenta;
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(85, 25);
            DeleteBtn.Text = "Удалить";
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSize = false;
            SaveBtn.BackColor = Color.SteelBlue;
            SaveBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SaveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.Image = (Image)resources.GetObject("SaveBtn.Image");
            SaveBtn.ImageTransparentColor = Color.Magenta;
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(85, 25);
            SaveBtn.Text = "Сохранить";
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LoadBtn
            // 
            LoadBtn.AutoSize = false;
            LoadBtn.BackColor = Color.Wheat;
            LoadBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LoadBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoadBtn.Image = (Image)resources.GetObject("LoadBtn.Image");
            LoadBtn.ImageTransparentColor = Color.Magenta;
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(85, 25);
            LoadBtn.Text = "Загрузить";
            LoadBtn.Click += LoadBtn_Click;
            // 
            // BookTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(toolStrip1);
            Controls.Add(BookDataGV);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookTableForm";
            Text = "Библиотека - Книги";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)BookDataGV).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BookDataGV;
        private ToolStrip toolStrip1;
        private ToolStripButton FindButton;
        private ToolStripTextBox FindBox;
        private ToolStripComboBox MethodComboBox;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox GenreComboBox;
        private ToolStripButton DeleteBtn;
        private ToolStripButton AddNewBox;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private ToolStripButton SaveBtn;
        private ToolStripButton LoadBtn;
        private DataGridViewTextBoxColumn IdClmn;
        private DataGridViewTextBoxColumn NameClmn;
        private DataGridViewTextBoxColumn AuthorClmn;
        private DataGridViewTextBoxColumn IsdClmn;
        private DataGridViewTextBoxColumn GenreClmn;
        private DataGridViewTextBoxColumn AmountClmn;
    }
}