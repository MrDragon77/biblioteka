namespace biblaoteka
{
    partial class BookForm
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
            IsdTextBox = new TextBox();
            IsdLbl = new Label();
            AuthorTextBox = new TextBox();
            AuthorLbl = new Label();
            NameTextBox = new TextBox();
            IdLabel = new Label();
            IdTextBox = new TextBox();
            NameLbl = new Label();
            GenreLbl = new Label();
            AmountTextBox = new TextBox();
            AmountLbl = new Label();
            GenreBox = new ComboBox();
            LendBtn = new Button();
            CancelBtn = new Button();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // IsdTextBox
            // 
            IsdTextBox.Location = new Point(161, 127);
            IsdTextBox.Margin = new Padding(3, 4, 3, 4);
            IsdTextBox.Name = "IsdTextBox";
            IsdTextBox.Size = new Size(332, 27);
            IsdTextBox.TabIndex = 15;
            // 
            // IsdLbl
            // 
            IsdLbl.AutoSize = true;
            IsdLbl.Location = new Point(9, 131);
            IsdLbl.Name = "IsdLbl";
            IsdLbl.Size = new Size(69, 20);
            IsdLbl.TabIndex = 14;
            IsdLbl.Text = "Издание";
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(161, 88);
            AuthorTextBox.Margin = new Padding(3, 4, 3, 4);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(332, 27);
            AuthorTextBox.TabIndex = 13;
            // 
            // AuthorLbl
            // 
            AuthorLbl.AutoSize = true;
            AuthorLbl.Location = new Point(9, 91);
            AuthorLbl.Name = "AuthorLbl";
            AuthorLbl.Size = new Size(51, 20);
            AuthorLbl.TabIndex = 12;
            AuthorLbl.Text = "Автор";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(161, 50);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(332, 27);
            NameTextBox.TabIndex = 11;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(9, 15);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(22, 20);
            IdLabel.TabIndex = 10;
            IdLabel.Text = "Id";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(161, 11);
            IdTextBox.Margin = new Padding(3, 4, 3, 4);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(332, 27);
            IdTextBox.TabIndex = 9;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(9, 54);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(77, 20);
            NameLbl.TabIndex = 8;
            NameLbl.Text = "Название";
            // 
            // GenreLbl
            // 
            GenreLbl.AutoSize = true;
            GenreLbl.Location = new Point(9, 172);
            GenreLbl.Name = "GenreLbl";
            GenreLbl.Size = new Size(48, 20);
            GenreLbl.TabIndex = 16;
            GenreLbl.Text = "Жанр";
            // 
            // AmountTextBox
            // 
            AmountTextBox.Location = new Point(161, 209);
            AmountTextBox.Margin = new Padding(3, 4, 3, 4);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(332, 27);
            AmountTextBox.TabIndex = 19;
            // 
            // AmountLbl
            // 
            AmountLbl.AutoSize = true;
            AmountLbl.Location = new Point(9, 213);
            AmountLbl.Name = "AmountLbl";
            AmountLbl.Size = new Size(90, 20);
            AmountLbl.TabIndex = 18;
            AmountLbl.Text = "Количество";
            // 
            // GenreBox
            // 
            GenreBox.FormattingEnabled = true;
            GenreBox.Items.AddRange(new object[] { "Неизвестен", "Роман", "Комедия", "Драма" });
            GenreBox.Location = new Point(160, 169);
            GenreBox.Name = "GenreBox";
            GenreBox.Size = new Size(333, 28);
            GenreBox.TabIndex = 20;
            // 
            // LendBtn
            // 
            LendBtn.Location = new Point(9, 429);
            LendBtn.Name = "LendBtn";
            LendBtn.Size = new Size(117, 49);
            LendBtn.TabIndex = 21;
            LendBtn.Text = "Выдать книгу";
            LendBtn.UseVisualStyleBackColor = true;
            LendBtn.Click += LendBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(389, 429);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(106, 49);
            CancelBtn.TabIndex = 22;
            CancelBtn.Text = "Назад";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(387, 257);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(106, 60);
            SaveBtn.TabIndex = 23;
            SaveBtn.Text = "Сохранить";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(507, 490);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            Controls.Add(LendBtn);
            Controls.Add(GenreBox);
            Controls.Add(AmountTextBox);
            Controls.Add(AmountLbl);
            Controls.Add(GenreLbl);
            Controls.Add(IsdTextBox);
            Controls.Add(IsdLbl);
            Controls.Add(AuthorTextBox);
            Controls.Add(AuthorLbl);
            Controls.Add(NameTextBox);
            Controls.Add(IdLabel);
            Controls.Add(IdTextBox);
            Controls.Add(NameLbl);
            Name = "BookForm";
            Text = "Страница книги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IsdTextBox;
        private Label IsdLbl;
        private TextBox AuthorTextBox;
        private Label AuthorLbl;
        private TextBox NameTextBox;
        private Label IdLabel;
        private TextBox IdTextBox;
        private Label NameLbl;
        private TextBox textBox1;
        private Label GenreLbl;
        private TextBox AmountTextBox;
        private Label AmountLbl;
        private ComboBox GenreBox;
        private Button LendBtn;
        private Button CancelBtn;
        private Button SaveBtn;
    }
}