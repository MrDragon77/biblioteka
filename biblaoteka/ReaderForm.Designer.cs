namespace biblaoteka
{
    partial class ReaderForm
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
            ReaderFullNameLabel = new Label();
            ReaderIndexTextBox = new TextBox();
            ReaderFullNameTextBox = new TextBox();
            ReaderIndexLabel = new Label();
            ReaderBirthDateTextBox = new TextBox();
            ReaderBirthDateLabel = new Label();
            ReaderAmountTakenBooksTextBox = new TextBox();
            ReaderAmountTakenBooksLabel = new Label();
            label6 = new Label();
            SaveChangesButton = new Button();
            DiscardChangesButton = new Button();
            BackButton = new Button();
            TakenBooksDataGridView = new DataGridView();
            BookIndex = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            TakenDate = new DataGridViewTextBoxColumn();
            ReturnDate = new DataGridViewTextBoxColumn();
            ToLendButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)TakenBooksDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ReaderFullNameLabel
            // 
            ReaderFullNameLabel.AutoSize = true;
            ReaderFullNameLabel.Location = new Point(12, 50);
            ReaderFullNameLabel.Name = "ReaderFullNameLabel";
            ReaderFullNameLabel.Size = new Size(34, 15);
            ReaderFullNameLabel.TabIndex = 0;
            ReaderFullNameLabel.Text = "ФИО";
            // 
            // ReaderIndexTextBox
            // 
            ReaderIndexTextBox.Location = new Point(145, 18);
            ReaderIndexTextBox.Name = "ReaderIndexTextBox";
            ReaderIndexTextBox.ReadOnly = true;
            ReaderIndexTextBox.Size = new Size(291, 23);
            ReaderIndexTextBox.TabIndex = 1;
            // 
            // ReaderFullNameTextBox
            // 
            ReaderFullNameTextBox.Location = new Point(145, 47);
            ReaderFullNameTextBox.Name = "ReaderFullNameTextBox";
            ReaderFullNameTextBox.Size = new Size(291, 23);
            ReaderFullNameTextBox.TabIndex = 3;
            ReaderFullNameTextBox.TextChanged += ReaderFullNameTextBox_TextChanged;
            // 
            // ReaderIndexLabel
            // 
            ReaderIndexLabel.AutoSize = true;
            ReaderIndexLabel.Location = new Point(12, 21);
            ReaderIndexLabel.Name = "ReaderIndexLabel";
            ReaderIndexLabel.Size = new Size(47, 15);
            ReaderIndexLabel.TabIndex = 2;
            ReaderIndexLabel.Text = "Индекс";
            // 
            // ReaderBirthDateTextBox
            // 
            ReaderBirthDateTextBox.Location = new Point(145, 76);
            ReaderBirthDateTextBox.Name = "ReaderBirthDateTextBox";
            ReaderBirthDateTextBox.Size = new Size(291, 23);
            ReaderBirthDateTextBox.TabIndex = 5;
            ReaderBirthDateTextBox.TextChanged += ReaderFullNameTextBox_TextChanged;
            // 
            // ReaderBirthDateLabel
            // 
            ReaderBirthDateLabel.AutoSize = true;
            ReaderBirthDateLabel.Location = new Point(12, 79);
            ReaderBirthDateLabel.Name = "ReaderBirthDateLabel";
            ReaderBirthDateLabel.Size = new Size(90, 15);
            ReaderBirthDateLabel.TabIndex = 4;
            ReaderBirthDateLabel.Text = "Дата рождения";
            // 
            // ReaderAmountTakenBooksTextBox
            // 
            ReaderAmountTakenBooksTextBox.Location = new Point(145, 105);
            ReaderAmountTakenBooksTextBox.Name = "ReaderAmountTakenBooksTextBox";
            ReaderAmountTakenBooksTextBox.ReadOnly = true;
            ReaderAmountTakenBooksTextBox.Size = new Size(291, 23);
            ReaderAmountTakenBooksTextBox.TabIndex = 7;
            // 
            // ReaderAmountTakenBooksLabel
            // 
            ReaderAmountTakenBooksLabel.AutoSize = true;
            ReaderAmountTakenBooksLabel.Location = new Point(12, 108);
            ReaderAmountTakenBooksLabel.Name = "ReaderAmountTakenBooksLabel";
            ReaderAmountTakenBooksLabel.Size = new Size(114, 15);
            ReaderAmountTakenBooksLabel.TabIndex = 6;
            ReaderAmountTakenBooksLabel.Text = "Кол-во взятых книг";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(315, 140);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 10;
            label6.Text = "Таблица взятых книг";
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(265, 380);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(85, 57);
            SaveChangesButton.TabIndex = 11;
            SaveChangesButton.Text = "Сохранить изменения";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Visible = false;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // DiscardChangesButton
            // 
            DiscardChangesButton.Location = new Point(355, 380);
            DiscardChangesButton.Name = "DiscardChangesButton";
            DiscardChangesButton.Size = new Size(83, 57);
            DiscardChangesButton.TabIndex = 12;
            DiscardChangesButton.Text = "Отменить изменения";
            DiscardChangesButton.UseVisualStyleBackColor = true;
            DiscardChangesButton.Visible = false;
            DiscardChangesButton.Click += DiscardChangesButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 410);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(71, 27);
            BackButton.TabIndex = 13;
            BackButton.Text = "<- Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // TakenBooksDataGridView
            // 
            TakenBooksDataGridView.AllowUserToAddRows = false;
            TakenBooksDataGridView.AllowUserToDeleteRows = false;
            TakenBooksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TakenBooksDataGridView.Columns.AddRange(new DataGridViewColumn[] { BookIndex, BookName, TakenDate, ReturnDate });
            TakenBooksDataGridView.Location = new Point(12, 158);
            TakenBooksDataGridView.Name = "TakenBooksDataGridView";
            TakenBooksDataGridView.ReadOnly = true;
            TakenBooksDataGridView.RowHeadersWidth = 51;
            TakenBooksDataGridView.RowTemplate.Height = 25;
            TakenBooksDataGridView.Size = new Size(424, 208);
            TakenBooksDataGridView.TabIndex = 14;
            // 
            // BookIndex
            // 
            BookIndex.HeaderText = "Индекс Книги";
            BookIndex.MinimumWidth = 6;
            BookIndex.Name = "BookIndex";
            BookIndex.ReadOnly = true;
            BookIndex.Width = 80;
            // 
            // BookName
            // 
            BookName.HeaderText = "Название книги";
            BookName.MinimumWidth = 6;
            BookName.Name = "BookName";
            BookName.ReadOnly = true;
            BookName.Width = 125;
            // 
            // TakenDate
            // 
            TakenDate.HeaderText = "Когда взята";
            TakenDate.MinimumWidth = 6;
            TakenDate.Name = "TakenDate";
            TakenDate.ReadOnly = true;
            TakenDate.Width = 125;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "Когда вернуть";
            ReturnDate.MinimumWidth = 6;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            ReturnDate.Width = 125;
            // 
            // ToLendButton
            // 
            ToLendButton.Location = new Point(97, 380);
            ToLendButton.Name = "ToLendButton";
            ToLendButton.Size = new Size(74, 57);
            ToLendButton.TabIndex = 15;
            ToLendButton.Text = "Выдать книгу";
            ToLendButton.UseVisualStyleBackColor = true;
            ToLendButton.Click += ToLendButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(177, 380);
            button1.Name = "button1";
            button1.Size = new Size(74, 57);
            button1.TabIndex = 16;
            button1.Text = "Принять книгу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 192, 189);
            ClientSize = new Size(450, 449);
            Controls.Add(button1);
            Controls.Add(ToLendButton);
            Controls.Add(TakenBooksDataGridView);
            Controls.Add(BackButton);
            Controls.Add(DiscardChangesButton);
            Controls.Add(SaveChangesButton);
            Controls.Add(label6);
            Controls.Add(ReaderAmountTakenBooksTextBox);
            Controls.Add(ReaderAmountTakenBooksLabel);
            Controls.Add(ReaderBirthDateTextBox);
            Controls.Add(ReaderBirthDateLabel);
            Controls.Add(ReaderFullNameTextBox);
            Controls.Add(ReaderIndexLabel);
            Controls.Add(ReaderIndexTextBox);
            Controls.Add(ReaderFullNameLabel);
            Name = "ReaderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Библиотека - Окно читателя";
            ((System.ComponentModel.ISupportInitialize)TakenBooksDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ReaderFullNameLabel;
        private TextBox ReaderIndexTextBox;
        private TextBox ReaderFullNameTextBox;
        private Label ReaderIndexLabel;
        private TextBox ReaderBirthDateTextBox;
        private Label ReaderBirthDateLabel;
        private TextBox ReaderAmountTakenBooksTextBox;
        private Label ReaderAmountTakenBooksLabel;
        private Label label6;
        private Button SaveChangesButton;
        private Button DiscardChangesButton;
        private Button BackButton;
        private DataGridView TakenBooksDataGridView;
        private DataGridViewTextBoxColumn BookIndex;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn TakenDate;
        private DataGridViewTextBoxColumn ReturnDate;
        private Button ToLendButton;
        private Button button1;
    }
}