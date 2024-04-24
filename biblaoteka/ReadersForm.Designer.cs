namespace biblaoteka
{
    partial class ReadersForm
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
            FullName = new DataGridViewTextBoxColumn();
            BirthDate = new DataGridViewTextBoxColumn();
            AmountTakenBooks = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ReadersTableDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ReadersTableDataGridView
            // 
            ReadersTableDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReadersTableDataGridView.Columns.AddRange(new DataGridViewColumn[] { FullName, BirthDate, AmountTakenBooks });
            ReadersTableDataGridView.Location = new Point(12, 12);
            ReadersTableDataGridView.Name = "ReadersTableDataGridView";
            ReadersTableDataGridView.RowTemplate.Height = 25;
            ReadersTableDataGridView.Size = new Size(407, 250);
            ReadersTableDataGridView.TabIndex = 0;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            // 
            // BirthDate
            // 
            BirthDate.HeaderText = "Birth Date";
            BirthDate.Name = "BirthDate";
            // 
            // AmountTakenBooks
            // 
            AmountTakenBooks.HeaderText = "Amount of Taken Books";
            AmountTakenBooks.Name = "AmountTakenBooks";
            // 
            // ReadersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReadersTableDataGridView);
            Name = "ReadersForm";
            Text = "ReadersForm";
            ((System.ComponentModel.ISupportInitialize)ReadersTableDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReadersTableDataGridView;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn AmountTakenBooks;
    }
}