namespace biblaoteka
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            NameAddBox = new TextBox();
            AuthorAddBox = new TextBox();
            IsdAddBox = new TextBox();
            GenreAddBox = new ComboBox();
            AmountUpDown = new NumericUpDown();
            CancelAdd = new Button();
            ConfirmAdd = new Button();
            ErrorLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)AmountUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bell MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 20);
            label1.Name = "label1";
            label1.Size = new Size(237, 31);
            label1.TabIndex = 0;
            label1.Text = "Добавление книги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(91, 37);
            label3.TabIndex = 2;
            label3.Text = "Автор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(124, 37);
            label4.TabIndex = 3;
            label4.Text = "Издание";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 234);
            label5.Name = "label5";
            label5.Size = new Size(86, 37);
            label5.TabIndex = 4;
            label5.Text = "Жанр";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 271);
            label6.Name = "label6";
            label6.Size = new Size(161, 37);
            label6.TabIndex = 5;
            label6.Text = "Количество";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 61);
            label7.Name = "label7";
            label7.Size = new Size(355, 56);
            label7.TabIndex = 6;
            label7.Text = "Введите данные книги, которую вы\r\nхотите добавить в список билиотеки.\r\n";
            // 
            // NameAddBox
            // 
            NameAddBox.Location = new Point(180, 133);
            NameAddBox.Name = "NameAddBox";
            NameAddBox.Size = new Size(200, 27);
            NameAddBox.TabIndex = 8;
            // 
            // AuthorAddBox
            // 
            AuthorAddBox.Location = new Point(180, 171);
            AuthorAddBox.Name = "AuthorAddBox";
            AuthorAddBox.Size = new Size(200, 27);
            AuthorAddBox.TabIndex = 9;
            // 
            // IsdAddBox
            // 
            IsdAddBox.Location = new Point(180, 208);
            IsdAddBox.Name = "IsdAddBox";
            IsdAddBox.Size = new Size(200, 27);
            IsdAddBox.TabIndex = 10;
            // 
            // GenreAddBox
            // 
            GenreAddBox.FormattingEnabled = true;
            GenreAddBox.Items.AddRange(new object[] { "Неизвестен", "Роман", "Комедия", "Драма" });
            GenreAddBox.Location = new Point(180, 245);
            GenreAddBox.Name = "GenreAddBox";
            GenreAddBox.Size = new Size(200, 28);
            GenreAddBox.TabIndex = 11;
            // 
            // AmountUpDown
            // 
            AmountUpDown.Location = new Point(180, 279);
            AmountUpDown.Name = "AmountUpDown";
            AmountUpDown.Size = new Size(75, 27);
            AmountUpDown.TabIndex = 12;
            // 
            // CancelAdd
            // 
            CancelAdd.BackColor = Color.Brown;
            CancelAdd.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CancelAdd.Location = new Point(270, 360);
            CancelAdd.Name = "CancelAdd";
            CancelAdd.Size = new Size(110, 40);
            CancelAdd.TabIndex = 14;
            CancelAdd.Text = "Отмена";
            CancelAdd.UseVisualStyleBackColor = false;
            CancelAdd.Click += CancelAdd_Click;
            // 
            // ConfirmAdd
            // 
            ConfirmAdd.BackColor = Color.LightGreen;
            ConfirmAdd.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmAdd.Location = new Point(15, 360);
            ConfirmAdd.Name = "ConfirmAdd";
            ConfirmAdd.Size = new Size(110, 40);
            ConfirmAdd.TabIndex = 15;
            ConfirmAdd.Text = "Добавить";
            ConfirmAdd.UseVisualStyleBackColor = false;
            ConfirmAdd.Click += ConfirmAdd_Click;
            // 
            // ErrorLbl
            // 
            ErrorLbl.AutoSize = true;
            ErrorLbl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorLbl.ForeColor = Color.Maroon;
            ErrorLbl.Location = new Point(12, 311);
            ErrorLbl.Name = "ErrorLbl";
            ErrorLbl.Size = new Size(322, 46);
            ErrorLbl.TabIndex = 16;
            ErrorLbl.Text = "Вы не задали некоторые параметры.\r\nДобавление невозможно.";
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(392, 424);
            Controls.Add(ErrorLbl);
            Controls.Add(ConfirmAdd);
            Controls.Add(CancelAdd);
            Controls.Add(AmountUpDown);
            Controls.Add(GenreAddBox);
            Controls.Add(IsdAddBox);
            Controls.Add(AuthorAddBox);
            Controls.Add(NameAddBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBookForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox NameAddBox;
        private TextBox AuthorAddBox;
        private TextBox IsdAddBox;
        private ComboBox GenreAddBox;
        private NumericUpDown AmountUpDown;
        private Button CancelAdd;
        private Button ConfirmAdd;
        private Label ErrorLbl;
    }
}