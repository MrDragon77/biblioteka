﻿namespace biblaoteka
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
            fixbutton = new Button();
            BackButton = new Button();
            NewReaderButton = new Button();
            Index = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            AmountTakenBooks = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ReadersTableDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ReadersTableDataGridView
            // 
            ReadersTableDataGridView.AllowUserToAddRows = false;
            ReadersTableDataGridView.AllowUserToDeleteRows = false;
            ReadersTableDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReadersTableDataGridView.Columns.AddRange(new DataGridViewColumn[] { Index, FullName, BirthDate, AmountTakenBooks });
            ReadersTableDataGridView.Location = new Point(12, 12);
            ReadersTableDataGridView.Name = "ReadersTableDataGridView";
            ReadersTableDataGridView.ReadOnly = true;
            ReadersTableDataGridView.RowTemplate.Height = 25;
            ReadersTableDataGridView.Size = new Size(776, 250);
            ReadersTableDataGridView.TabIndex = 0;
            ReadersTableDataGridView.CellDoubleClick += ReadersTableDataGridView_CellDoubleClick;
            // 
            // fixbutton
            // 
            fixbutton.Location = new Point(169, 384);
            fixbutton.Name = "fixbutton";
            fixbutton.Size = new Size(82, 54);
            fixbutton.TabIndex = 1;
            fixbutton.Text = "почини индексы";
            fixbutton.UseVisualStyleBackColor = true;
            fixbutton.Click += fixbutton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(12, 384);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(105, 54);
            BackButton.TabIndex = 2;
            BackButton.Text = "<- Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // NewReaderButton
            // 
            NewReaderButton.Location = new Point(675, 382);
            NewReaderButton.Name = "NewReaderButton";
            NewReaderButton.Size = new Size(102, 50);
            NewReaderButton.TabIndex = 3;
            NewReaderButton.Text = "Добавить читателя";
            NewReaderButton.UseVisualStyleBackColor = true;
            NewReaderButton.Click += NewReaderButton_Click;
            // 
            // Index
            // 
            Index.HeaderText = "Индекс";
            Index.Name = "Index";
            Index.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.HeaderText = "ФИО";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 200;
            // 
            // BirthDate
            // 
            BirthDate.HeaderText = "Дата рождения";
            BirthDate.Name = "BirthDate";
            BirthDate.ReadOnly = true;
            // 
            // AmountTakenBooks
            // 
            AmountTakenBooks.HeaderText = "Кол-во взятых книг";
            AmountTakenBooks.Name = "AmountTakenBooks";
            AmountTakenBooks.ReadOnly = true;
            // 
            // ReadersTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NewReaderButton);
            Controls.Add(BackButton);
            Controls.Add(fixbutton);
            Controls.Add(ReadersTableDataGridView);
            Name = "ReadersTableForm";
            Text = "Библиотека - Читатели";
            ((System.ComponentModel.ISupportInitialize)ReadersTableDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReadersTableDataGridView;
        private Button fixbutton;
        private Button BackButton;
        private Button NewReaderButton;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn AmountTakenBooks;
    }
}