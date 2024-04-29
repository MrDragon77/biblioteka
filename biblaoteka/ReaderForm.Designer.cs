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
            dataGridView1 = new DataGridView();
            BookIndex = new DataGridViewTextBoxColumn();
            BookName = new DataGridViewTextBoxColumn();
            TakenDate = new DataGridViewTextBoxColumn();
            ReturnDate = new DataGridViewTextBoxColumn();
            ToLendButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ReaderFullNameLabel
            // 
            ReaderFullNameLabel.AutoSize = true;
            ReaderFullNameLabel.Location = new Point(14, 67);
            ReaderFullNameLabel.Name = "ReaderFullNameLabel";
            ReaderFullNameLabel.Size = new Size(42, 20);
            ReaderFullNameLabel.TabIndex = 0;
            ReaderFullNameLabel.Text = "ФИО";
            // 
            // ReaderIndexTextBox
            // 
            ReaderIndexTextBox.Location = new Point(166, 24);
            ReaderIndexTextBox.Margin = new Padding(3, 4, 3, 4);
            ReaderIndexTextBox.Name = "ReaderIndexTextBox";
            ReaderIndexTextBox.ReadOnly = true;
            ReaderIndexTextBox.Size = new Size(332, 27);
            ReaderIndexTextBox.TabIndex = 1;
            // 
            // ReaderFullNameTextBox
            // 
            ReaderFullNameTextBox.Location = new Point(166, 63);
            ReaderFullNameTextBox.Margin = new Padding(3, 4, 3, 4);
            ReaderFullNameTextBox.Name = "ReaderFullNameTextBox";
            ReaderFullNameTextBox.Size = new Size(332, 27);
            ReaderFullNameTextBox.TabIndex = 3;
            ReaderFullNameTextBox.TextChanged += ReaderFullNameTextBox_TextChanged;
            // 
            // ReaderIndexLabel
            // 
            ReaderIndexLabel.AutoSize = true;
            ReaderIndexLabel.Location = new Point(14, 28);
            ReaderIndexLabel.Name = "ReaderIndexLabel";
            ReaderIndexLabel.Size = new Size(59, 20);
            ReaderIndexLabel.TabIndex = 2;
            ReaderIndexLabel.Text = "Индекс";
            // 
            // ReaderBirthDateTextBox
            // 
            ReaderBirthDateTextBox.Location = new Point(166, 101);
            ReaderBirthDateTextBox.Margin = new Padding(3, 4, 3, 4);
            ReaderBirthDateTextBox.Name = "ReaderBirthDateTextBox";
            ReaderBirthDateTextBox.Size = new Size(332, 27);
            ReaderBirthDateTextBox.TabIndex = 5;
            ReaderBirthDateTextBox.TextChanged += ReaderFullNameTextBox_TextChanged;
            // 
            // ReaderBirthDateLabel
            // 
            ReaderBirthDateLabel.AutoSize = true;
            ReaderBirthDateLabel.Location = new Point(14, 105);
            ReaderBirthDateLabel.Name = "ReaderBirthDateLabel";
            ReaderBirthDateLabel.Size = new Size(116, 20);
            ReaderBirthDateLabel.TabIndex = 4;
            ReaderBirthDateLabel.Text = "Дата рождения";
            // 
            // ReaderAmountTakenBooksTextBox
            // 
            ReaderAmountTakenBooksTextBox.Location = new Point(166, 140);
            ReaderAmountTakenBooksTextBox.Margin = new Padding(3, 4, 3, 4);
            ReaderAmountTakenBooksTextBox.Name = "ReaderAmountTakenBooksTextBox";
            ReaderAmountTakenBooksTextBox.ReadOnly = true;
            ReaderAmountTakenBooksTextBox.Size = new Size(332, 27);
            ReaderAmountTakenBooksTextBox.TabIndex = 7;
            // 
            // ReaderAmountTakenBooksLabel
            // 
            ReaderAmountTakenBooksLabel.AutoSize = true;
            ReaderAmountTakenBooksLabel.Location = new Point(14, 144);
            ReaderAmountTakenBooksLabel.Name = "ReaderAmountTakenBooksLabel";
            ReaderAmountTakenBooksLabel.Size = new Size(144, 20);
            ReaderAmountTakenBooksLabel.TabIndex = 6;
            ReaderAmountTakenBooksLabel.Text = "Кол-во взятых книг";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 187);
            label6.Name = "label6";
            label6.Size = new Size(154, 20);
            label6.TabIndex = 10;
            label6.Text = "Таблица взятых книг";
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(303, 507);
            SaveChangesButton.Margin = new Padding(3, 4, 3, 4);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(97, 76);
            SaveChangesButton.TabIndex = 11;
            SaveChangesButton.Text = "Сохранить изменения";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Visible = false;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // DiscardChangesButton
            // 
            DiscardChangesButton.Location = new Point(406, 507);
            DiscardChangesButton.Margin = new Padding(3, 4, 3, 4);
            DiscardChangesButton.Name = "DiscardChangesButton";
            DiscardChangesButton.Size = new Size(95, 76);
            DiscardChangesButton.TabIndex = 12;
            DiscardChangesButton.Text = "Отменить изменения";
            DiscardChangesButton.UseVisualStyleBackColor = true;
            DiscardChangesButton.Visible = false;
            DiscardChangesButton.Click += DiscardChangesButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(14, 547);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(81, 36);
            BackButton.TabIndex = 13;
            BackButton.Text = "<- Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookIndex, BookName, TakenDate, ReturnDate });
            dataGridView1.Location = new Point(14, 211);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(485, 277);
            dataGridView1.TabIndex = 14;
            // 
            // BookIndex
            // 
            BookIndex.HeaderText = "Индекс Книги";
            BookIndex.MinimumWidth = 6;
            BookIndex.Name = "BookIndex";
            BookIndex.Width = 80;
            // 
            // BookName
            // 
            BookName.HeaderText = "Название книги";
            BookName.MinimumWidth = 6;
            BookName.Name = "BookName";
            BookName.Width = 125;
            // 
            // TakenDate
            // 
            TakenDate.HeaderText = "Когда взята";
            TakenDate.MinimumWidth = 6;
            TakenDate.Name = "TakenDate";
            TakenDate.Width = 125;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "Когда вернуть";
            ReturnDate.MinimumWidth = 6;
            ReturnDate.Name = "ReturnDate";
            ReturnDate.Width = 125;
            // 
            // ToLendButton
            // 
            ToLendButton.Location = new Point(111, 507);
            ToLendButton.Margin = new Padding(3, 4, 3, 4);
            ToLendButton.Name = "ToLendButton";
            ToLendButton.Size = new Size(85, 76);
            ToLendButton.TabIndex = 15;
            ToLendButton.Text = "Выдать книгу";
            ToLendButton.UseVisualStyleBackColor = true;
            ToLendButton.Click += ToLendButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(202, 507);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(85, 76);
            button1.TabIndex = 16;
            button1.Text = "Принять книгу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReaderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 192, 189);
            ClientSize = new Size(514, 599);
            Controls.Add(button1);
            Controls.Add(ToLendButton);
            Controls.Add(dataGridView1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReaderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Библиотека - Окно читателя";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BookIndex;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn TakenDate;
        private DataGridViewTextBoxColumn ReturnDate;
        private Button ToLendButton;
        private Button button1;
    }
}