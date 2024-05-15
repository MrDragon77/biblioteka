namespace biblaoteka
{
    partial class ReadersTableForm
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
            ReadersTableDataGridView = new DataGridView();
            Index = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            AmountTakenBooks = new DataGridViewTextBoxColumn();
            BackButton = new Button();
            NewReaderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ReadersTableDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ReadersTableDataGridView
            // 
            ReadersTableDataGridView.AllowUserToAddRows = false;
            ReadersTableDataGridView.AllowUserToDeleteRows = false;
            ReadersTableDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReadersTableDataGridView.Columns.AddRange(new DataGridViewColumn[] { Index, FullName, BirthDate, AmountTakenBooks });
            ReadersTableDataGridView.Location = new Point(14, 16);
            ReadersTableDataGridView.Margin = new Padding(3, 4, 3, 4);
            ReadersTableDataGridView.Name = "ReadersTableDataGridView";
            ReadersTableDataGridView.ReadOnly = true;
            ReadersTableDataGridView.RowHeadersWidth = 51;
            ReadersTableDataGridView.RowTemplate.Height = 25;
            ReadersTableDataGridView.Size = new Size(887, 468);
            ReadersTableDataGridView.TabIndex = 0;
            ReadersTableDataGridView.CellDoubleClick += ReadersTableDataGridView_CellDoubleClick;
            // 
            // Index
            // 
            Index.HeaderText = "Индекс";
            Index.MinimumWidth = 6;
            Index.Name = "Index";
            Index.ReadOnly = true;
            Index.Width = 125;
            // 
            // FullName
            // 
            FullName.HeaderText = "ФИО";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 400;
            // 
            // BirthDate
            // 
            BirthDate.HeaderText = "Дата рождения";
            BirthDate.MinimumWidth = 6;
            BirthDate.Name = "BirthDate";
            BirthDate.ReadOnly = true;
            BirthDate.Width = 125;
            // 
            // AmountTakenBooks
            // 
            AmountTakenBooks.HeaderText = "Кол-во взятых книг";
            AmountTakenBooks.MinimumWidth = 6;
            AmountTakenBooks.Name = "AmountTakenBooks";
            AmountTakenBooks.ReadOnly = true;
            AmountTakenBooks.Width = 125;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(14, 545);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(81, 39);
            BackButton.TabIndex = 2;
            BackButton.Text = "<- Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // NewReaderButton
            // 
            NewReaderButton.Location = new Point(784, 517);
            NewReaderButton.Margin = new Padding(3, 4, 3, 4);
            NewReaderButton.Name = "NewReaderButton";
            NewReaderButton.Size = new Size(117, 67);
            NewReaderButton.TabIndex = 3;
            NewReaderButton.Text = "Добавить читателя";
            NewReaderButton.UseVisualStyleBackColor = true;
            NewReaderButton.Click += NewReaderButton_Click;
            // 
            // ReadersTableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 165, 162);
            ClientSize = new Size(914, 600);
            Controls.Add(NewReaderButton);
            Controls.Add(BackButton);
            Controls.Add(ReadersTableDataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReadersTableForm";
            Text = "Библиотека - Читатели";
            ((System.ComponentModel.ISupportInitialize)ReadersTableDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReadersTableDataGridView;
        private Button BackButton;
        private Button NewReaderButton;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn AmountTakenBooks;
    }
}