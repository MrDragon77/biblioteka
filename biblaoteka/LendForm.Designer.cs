namespace biblaoteka
{
    partial class LendForm
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
            label1 = new Label();
            label2 = new Label();
            ReaderFullNameTextBox = new TextBox();
            ReaderIndexLabel = new Label();
            ReaderIndexTextBox = new TextBox();
            ReaderFullNameLabel = new Label();
            BookNameTextBox = new TextBox();
            BookIndexLabel = new Label();
            BookIndexTextBox = new TextBox();
            BookNameLabel = new Label();
            ChooseBookButton = new Button();
            ChooseReaderButton = new Button();
            MoreBookButton = new Button();
            MoreReaderButton = new Button();
            LendButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Книга";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(369, 9);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Читатель";
            // 
            // ReaderFullNameTextBox
            // 
            ReaderFullNameTextBox.Location = new Point(456, 61);
            ReaderFullNameTextBox.Name = "ReaderFullNameTextBox";
            ReaderFullNameTextBox.ReadOnly = true;
            ReaderFullNameTextBox.Size = new Size(291, 23);
            ReaderFullNameTextBox.TabIndex = 7;
            // 
            // ReaderIndexLabel
            // 
            ReaderIndexLabel.AutoSize = true;
            ReaderIndexLabel.Location = new Point(369, 35);
            ReaderIndexLabel.Name = "ReaderIndexLabel";
            ReaderIndexLabel.Size = new Size(47, 15);
            ReaderIndexLabel.TabIndex = 6;
            ReaderIndexLabel.Text = "Индекс";
            // 
            // ReaderIndexTextBox
            // 
            ReaderIndexTextBox.Location = new Point(456, 32);
            ReaderIndexTextBox.Name = "ReaderIndexTextBox";
            ReaderIndexTextBox.ReadOnly = true;
            ReaderIndexTextBox.Size = new Size(291, 23);
            ReaderIndexTextBox.TabIndex = 5;
            // 
            // ReaderFullNameLabel
            // 
            ReaderFullNameLabel.AutoSize = true;
            ReaderFullNameLabel.Location = new Point(369, 64);
            ReaderFullNameLabel.Name = "ReaderFullNameLabel";
            ReaderFullNameLabel.Size = new Size(34, 15);
            ReaderFullNameLabel.TabIndex = 4;
            ReaderFullNameLabel.Text = "ФИО";
            // 
            // BookNameTextBox
            // 
            BookNameTextBox.Location = new Point(145, 61);
            BookNameTextBox.Name = "BookNameTextBox";
            BookNameTextBox.ReadOnly = true;
            BookNameTextBox.Size = new Size(176, 23);
            BookNameTextBox.TabIndex = 11;
            // 
            // BookIndexLabel
            // 
            BookIndexLabel.AutoSize = true;
            BookIndexLabel.Location = new Point(12, 35);
            BookIndexLabel.Name = "BookIndexLabel";
            BookIndexLabel.Size = new Size(47, 15);
            BookIndexLabel.TabIndex = 10;
            BookIndexLabel.Text = "Индекс";
            // 
            // BookIndexTextBox
            // 
            BookIndexTextBox.Location = new Point(145, 32);
            BookIndexTextBox.Name = "BookIndexTextBox";
            BookIndexTextBox.ReadOnly = true;
            BookIndexTextBox.Size = new Size(176, 23);
            BookIndexTextBox.TabIndex = 9;
            // 
            // BookNameLabel
            // 
            BookNameLabel.AutoSize = true;
            BookNameLabel.Location = new Point(12, 64);
            BookNameLabel.Name = "BookNameLabel";
            BookNameLabel.Size = new Size(59, 15);
            BookNameLabel.TabIndex = 8;
            BookNameLabel.Text = "Название";
            // 
            // ChooseBookButton
            // 
            ChooseBookButton.Location = new Point(12, 104);
            ChooseBookButton.Name = "ChooseBookButton";
            ChooseBookButton.Size = new Size(309, 37);
            ChooseBookButton.TabIndex = 12;
            ChooseBookButton.Text = "Выбрать книгу";
            ChooseBookButton.UseVisualStyleBackColor = true;
            ChooseBookButton.Click += ChooseBookButton_Click;
            // 
            // ChooseReaderButton
            // 
            ChooseReaderButton.Location = new Point(369, 104);
            ChooseReaderButton.Name = "ChooseReaderButton";
            ChooseReaderButton.Size = new Size(399, 37);
            ChooseReaderButton.TabIndex = 13;
            ChooseReaderButton.Text = "Выбрать читателя";
            ChooseReaderButton.UseVisualStyleBackColor = true;
            ChooseReaderButton.Click += ChooseReaderButton_Click;
            // 
            // MoreBookButton
            // 
            MoreBookButton.Location = new Point(12, 180);
            MoreBookButton.Name = "MoreBookButton";
            MoreBookButton.Size = new Size(309, 37);
            MoreBookButton.TabIndex = 14;
            MoreBookButton.Text = "Открыть страницу книги";
            MoreBookButton.UseVisualStyleBackColor = true;
            MoreBookButton.Click += MoreBookButton_Click;
            // 
            // MoreReaderButton
            // 
            MoreReaderButton.Location = new Point(369, 180);
            MoreReaderButton.Name = "MoreReaderButton";
            MoreReaderButton.Size = new Size(399, 37);
            MoreReaderButton.TabIndex = 15;
            MoreReaderButton.Text = "Открыть страницу читателя";
            MoreReaderButton.UseVisualStyleBackColor = true;
            MoreReaderButton.Click += MoreReaderButton_Click;
            // 
            // LendButton
            // 
            LendButton.Location = new Point(162, 376);
            LendButton.Name = "LendButton";
            LendButton.Size = new Size(399, 37);
            LendButton.TabIndex = 16;
            LendButton.Text = "Выдать книгу";
            LendButton.UseVisualStyleBackColor = true;
            LendButton.Click += LendButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 386);
            button1.Name = "button1";
            button1.Size = new Size(76, 26);
            button1.TabIndex = 17;
            button1.Text = "<- Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LendForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(LendButton);
            Controls.Add(MoreReaderButton);
            Controls.Add(MoreBookButton);
            Controls.Add(ChooseReaderButton);
            Controls.Add(ChooseBookButton);
            Controls.Add(BookNameTextBox);
            Controls.Add(BookIndexLabel);
            Controls.Add(BookIndexTextBox);
            Controls.Add(BookNameLabel);
            Controls.Add(ReaderFullNameTextBox);
            Controls.Add(ReaderIndexLabel);
            Controls.Add(ReaderIndexTextBox);
            Controls.Add(ReaderFullNameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LendForm";
            Text = "LendForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ReaderFullNameTextBox;
        private Label ReaderIndexLabel;
        private TextBox ReaderIndexTextBox;
        private Label ReaderFullNameLabel;
        private TextBox BookNameTextBox;
        private Label BookIndexLabel;
        private TextBox BookIndexTextBox;
        private Label BookNameLabel;
        private Button ChooseBookButton;
        private Button ChooseReaderButton;
        private Button MoreBookButton;
        private Button MoreReaderButton;
        private Button LendButton;
        private Button button1;
    }
}