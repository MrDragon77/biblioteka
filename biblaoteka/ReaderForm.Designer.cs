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
            SuspendLayout();
            // 
            // ReaderFullNameLabel
            // 
            ReaderFullNameLabel.AutoSize = true;
            ReaderFullNameLabel.Location = new Point(21, 53);
            ReaderFullNameLabel.Name = "ReaderFullNameLabel";
            ReaderFullNameLabel.Size = new Size(58, 15);
            ReaderFullNameLabel.TabIndex = 0;
            ReaderFullNameLabel.Text = "FullName";
            // 
            // ReaderIndexTextBox
            // 
            ReaderIndexTextBox.Location = new Point(159, 21);
            ReaderIndexTextBox.Name = "ReaderIndexTextBox";
            ReaderIndexTextBox.ReadOnly = true;
            ReaderIndexTextBox.Size = new Size(212, 23);
            ReaderIndexTextBox.TabIndex = 1;
            // 
            // ReaderFullNameTextBox
            // 
            ReaderFullNameTextBox.Location = new Point(159, 50);
            ReaderFullNameTextBox.Name = "ReaderFullNameTextBox";
            ReaderFullNameTextBox.Size = new Size(212, 23);
            ReaderFullNameTextBox.TabIndex = 3;
            ReaderFullNameTextBox.TextChanged += ReaderFullNameTextBox_TextChanged;
            // 
            // ReaderIndexLabel
            // 
            ReaderIndexLabel.AutoSize = true;
            ReaderIndexLabel.Location = new Point(21, 24);
            ReaderIndexLabel.Name = "ReaderIndexLabel";
            ReaderIndexLabel.Size = new Size(36, 15);
            ReaderIndexLabel.TabIndex = 2;
            ReaderIndexLabel.Text = "Index";
            // 
            // ReaderBirthDateTextBox
            // 
            ReaderBirthDateTextBox.Location = new Point(159, 78);
            ReaderBirthDateTextBox.Name = "ReaderBirthDateTextBox";
            ReaderBirthDateTextBox.Size = new Size(212, 23);
            ReaderBirthDateTextBox.TabIndex = 5;
            ReaderBirthDateTextBox.TextChanged += ReaderFullNameTextBox_TextChanged;
            // 
            // ReaderBirthDateLabel
            // 
            ReaderBirthDateLabel.AutoSize = true;
            ReaderBirthDateLabel.Location = new Point(21, 81);
            ReaderBirthDateLabel.Name = "ReaderBirthDateLabel";
            ReaderBirthDateLabel.Size = new Size(56, 15);
            ReaderBirthDateLabel.TabIndex = 4;
            ReaderBirthDateLabel.Text = "BirthDate";
            // 
            // ReaderAmountTakenBooksTextBox
            // 
            ReaderAmountTakenBooksTextBox.Location = new Point(159, 109);
            ReaderAmountTakenBooksTextBox.Name = "ReaderAmountTakenBooksTextBox";
            ReaderAmountTakenBooksTextBox.ReadOnly = true;
            ReaderAmountTakenBooksTextBox.Size = new Size(212, 23);
            ReaderAmountTakenBooksTextBox.TabIndex = 7;
            // 
            // ReaderAmountTakenBooksLabel
            // 
            ReaderAmountTakenBooksLabel.AutoSize = true;
            ReaderAmountTakenBooksLabel.Location = new Point(21, 112);
            ReaderAmountTakenBooksLabel.Name = "ReaderAmountTakenBooksLabel";
            ReaderAmountTakenBooksLabel.Size = new Size(133, 15);
            ReaderAmountTakenBooksLabel.TabIndex = 6;
            ReaderAmountTakenBooksLabel.Text = "Amount of Taken Books";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 194);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 10;
            label6.Text = "таблица взятых книг";
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.Location = new Point(608, 360);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(72, 57);
            SaveChangesButton.TabIndex = 11;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Visible = false;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // DiscardChangesButton
            // 
            DiscardChangesButton.Location = new Point(697, 360);
            DiscardChangesButton.Name = "DiscardChangesButton";
            DiscardChangesButton.Size = new Size(72, 57);
            DiscardChangesButton.TabIndex = 12;
            DiscardChangesButton.Text = "Discard Changes";
            DiscardChangesButton.UseVisualStyleBackColor = true;
            DiscardChangesButton.Visible = false;
            DiscardChangesButton.Click += DiscardChangesButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(21, 362);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(101, 52);
            BackButton.TabIndex = 13;
            BackButton.Text = "<- Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ReaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Text = "ReaderTable";
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
    }
}