namespace biblaoteka
{
    partial class MainForm
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
            BooksButton = new Button();
            AddBookButton = new Button();
            ReadersButton = new Button();
            SuspendLayout();
            // 
            // BooksButton
            // 
            BooksButton.Location = new Point(98, 137);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(94, 50);
            BooksButton.TabIndex = 0;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = true;
            BooksButton.Click += BooksButton_Click;
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(271, 137);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(94, 50);
            AddBookButton.TabIndex = 1;
            AddBookButton.Text = "Add book";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // ReadersButton
            // 
            ReadersButton.Location = new Point(456, 137);
            ReadersButton.Name = "ReadersButton";
            ReadersButton.Size = new Size(94, 50);
            ReadersButton.TabIndex = 2;
            ReadersButton.Text = "Readers";
            ReadersButton.UseVisualStyleBackColor = true;
            ReadersButton.Click += ReadersButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReadersButton);
            Controls.Add(AddBookButton);
            Controls.Add(BooksButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button BooksButton;
        private Button AddBookButton;
        private Button ReadersButton;
    }
}