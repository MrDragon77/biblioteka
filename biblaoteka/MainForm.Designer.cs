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
            LogOutButton = new Button();
            SuspendLayout();
            // 
            // BooksButton
            // 
            BooksButton.Location = new Point(112, 183);
            BooksButton.Margin = new Padding(3, 4, 3, 4);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(107, 67);
            BooksButton.TabIndex = 0;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = true;
            BooksButton.Click += BooksButton_Click;
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(310, 183);
            AddBookButton.Margin = new Padding(3, 4, 3, 4);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(107, 67);
            AddBookButton.TabIndex = 1;
            AddBookButton.Text = "Add book";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // ReadersButton
            // 
            ReadersButton.Location = new Point(521, 183);
            ReadersButton.Margin = new Padding(3, 4, 3, 4);
            ReadersButton.Name = "ReadersButton";
            ReadersButton.Size = new Size(107, 67);
            ReadersButton.TabIndex = 2;
            ReadersButton.Text = "Readers";
            ReadersButton.UseVisualStyleBackColor = true;
            ReadersButton.Click += ReadersButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Location = new Point(325, 198);
            LogOutButton.Margin = new Padding(3, 4, 3, 4);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(78, 36);
            LogOutButton.TabIndex = 3;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(LogOutButton);
            Controls.Add(ReadersButton);
            Controls.Add(AddBookButton);
            Controls.Add(BooksButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button BooksButton;
        private Button AddBookButton;
        private Button ReadersButton;
        private Button LogOutButton;
    }
}