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
            BooksButton.BackColor = Color.FromArgb(177, 216, 220);
            BooksButton.Location = new Point(86, 120);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(100, 200);
            BooksButton.TabIndex = 0;
            BooksButton.Text = "Books";
            BooksButton.UseVisualStyleBackColor = false;
            BooksButton.Click += BooksButton_Click;
            // 
            // AddBookButton
            // 
            AddBookButton.BackColor = Color.FromArgb(185, 210, 143);
            AddBookButton.Location = new Point(358, 120);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(100, 200);
            AddBookButton.TabIndex = 1;
            AddBookButton.Text = "Add book";
            AddBookButton.UseVisualStyleBackColor = false;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // ReadersButton
            // 
            ReadersButton.BackColor = Color.FromArgb(226, 144, 139);
            ReadersButton.Location = new Point(630, 120);
            ReadersButton.Name = "ReadersButton";
            ReadersButton.Size = new Size(100, 200);
            ReadersButton.TabIndex = 2;
            ReadersButton.Text = "Readers";
            ReadersButton.UseVisualStyleBackColor = false;
            ReadersButton.Click += ReadersButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LogOutButton.Location = new Point(12, 12);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(74, 28);
            LogOutButton.TabIndex = 3;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogOutButton);
            Controls.Add(ReadersButton);
            Controls.Add(AddBookButton);
            Controls.Add(BooksButton);
            Name = "MainForm";
            Text = "MainForm";
            Paint += MainForm_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button BooksButton;
        private Button AddBookButton;
        private Button ReadersButton;
        private Button LogOutButton;
    }
}