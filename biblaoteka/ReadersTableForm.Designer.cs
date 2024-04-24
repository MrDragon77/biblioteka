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
            fixbutton = new Button();
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
            // Index
            // 
            Index.HeaderText = "Index";
            Index.Name = "Index";
            Index.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 200;
            // 
            // BirthDate
            // 
            BirthDate.HeaderText = "Birth Date";
            BirthDate.Name = "BirthDate";
            BirthDate.ReadOnly = true;
            // 
            // AmountTakenBooks
            // 
            AmountTakenBooks.HeaderText = "Amount of Taken Books";
            AmountTakenBooks.Name = "AmountTakenBooks";
            AmountTakenBooks.ReadOnly = true;
            // 
            // fixbutton
            // 
            fixbutton.Location = new Point(12, 384);
            fixbutton.Name = "fixbutton";
            fixbutton.Size = new Size(82, 54);
            fixbutton.TabIndex = 1;
            fixbutton.Text = "fix indexes";
            fixbutton.UseVisualStyleBackColor = true;
            fixbutton.Click += fixbutton_Click;
            // 
            // ReadersTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fixbutton);
            Controls.Add(ReadersTableDataGridView);
            Name = "ReadersTableForm";
            Text = "ReadersForm";
            ((System.ComponentModel.ISupportInitialize)ReadersTableDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReadersTableDataGridView;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn AmountTakenBooks;
        private Button fixbutton;
    }
}