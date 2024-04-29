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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Книга";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 12);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Читатель";
            // 
            // ReaderFullNameTextBox
            // 
            ReaderFullNameTextBox.Location = new Point(521, 81);
            ReaderFullNameTextBox.Margin = new Padding(3, 4, 3, 4);
            ReaderFullNameTextBox.Name = "ReaderFullNameTextBox";
            ReaderFullNameTextBox.Size = new Size(332, 27);
            ReaderFullNameTextBox.TabIndex = 7;
            // 
            // ReaderIndexLabel
            // 
            ReaderIndexLabel.AutoSize = true;
            ReaderIndexLabel.Location = new Point(422, 47);
            ReaderIndexLabel.Name = "ReaderIndexLabel";
            ReaderIndexLabel.Size = new Size(59, 20);
            ReaderIndexLabel.TabIndex = 6;
            ReaderIndexLabel.Text = "Индекс";
            // 
            // ReaderIndexTextBox
            // 
            ReaderIndexTextBox.Location = new Point(521, 43);
            ReaderIndexTextBox.Margin = new Padding(3, 4, 3, 4);
            ReaderIndexTextBox.Name = "ReaderIndexTextBox";
            ReaderIndexTextBox.ReadOnly = true;
            ReaderIndexTextBox.Size = new Size(332, 27);
            ReaderIndexTextBox.TabIndex = 5;
            // 
            // ReaderFullNameLabel
            // 
            ReaderFullNameLabel.AutoSize = true;
            ReaderFullNameLabel.Location = new Point(422, 85);
            ReaderFullNameLabel.Name = "ReaderFullNameLabel";
            ReaderFullNameLabel.Size = new Size(42, 20);
            ReaderFullNameLabel.TabIndex = 4;
            ReaderFullNameLabel.Text = "ФИО";
            // 
            // BookNameTextBox
            // 
            BookNameTextBox.Location = new Point(166, 81);
            BookNameTextBox.Margin = new Padding(3, 4, 3, 4);
            BookNameTextBox.Name = "BookNameTextBox";
            BookNameTextBox.Size = new Size(201, 27);
            BookNameTextBox.TabIndex = 11;
            // 
            // BookIndexLabel
            // 
            BookIndexLabel.AutoSize = true;
            BookIndexLabel.Location = new Point(14, 47);
            BookIndexLabel.Name = "BookIndexLabel";
            BookIndexLabel.Size = new Size(59, 20);
            BookIndexLabel.TabIndex = 10;
            BookIndexLabel.Text = "Индекс";
            // 
            // BookIndexTextBox
            // 
            BookIndexTextBox.Location = new Point(166, 43);
            BookIndexTextBox.Margin = new Padding(3, 4, 3, 4);
            BookIndexTextBox.Name = "BookIndexTextBox";
            BookIndexTextBox.ReadOnly = true;
            BookIndexTextBox.Size = new Size(201, 27);
            BookIndexTextBox.TabIndex = 9;
            // 
            // BookNameLabel
            // 
            BookNameLabel.AutoSize = true;
            BookNameLabel.Location = new Point(14, 85);
            BookNameLabel.Name = "BookNameLabel";
            BookNameLabel.Size = new Size(77, 20);
            BookNameLabel.TabIndex = 8;
            BookNameLabel.Text = "Название";
            // 
            // ChooseBookButton
            // 
            ChooseBookButton.Location = new Point(14, 139);
            ChooseBookButton.Margin = new Padding(3, 4, 3, 4);
            ChooseBookButton.Name = "ChooseBookButton";
            ChooseBookButton.Size = new Size(353, 49);
            ChooseBookButton.TabIndex = 12;
            ChooseBookButton.Text = "Выбрать книгу";
            ChooseBookButton.UseVisualStyleBackColor = true;
            // 
            // ChooseReaderButton
            // 
            ChooseReaderButton.Location = new Point(422, 139);
            ChooseReaderButton.Margin = new Padding(3, 4, 3, 4);
            ChooseReaderButton.Name = "ChooseReaderButton";
            ChooseReaderButton.Size = new Size(456, 49);
            ChooseReaderButton.TabIndex = 13;
            ChooseReaderButton.Text = "Выбрать читателя";
            ChooseReaderButton.UseVisualStyleBackColor = true;
            // 
            // MoreBookButton
            // 
            MoreBookButton.Location = new Point(14, 240);
            MoreBookButton.Margin = new Padding(3, 4, 3, 4);
            MoreBookButton.Name = "MoreBookButton";
            MoreBookButton.Size = new Size(353, 49);
            MoreBookButton.TabIndex = 14;
            MoreBookButton.Text = "Открыть страницу книги";
            MoreBookButton.UseVisualStyleBackColor = true;
            // 
            // MoreReaderButton
            // 
            MoreReaderButton.Location = new Point(422, 240);
            MoreReaderButton.Margin = new Padding(3, 4, 3, 4);
            MoreReaderButton.Name = "MoreReaderButton";
            MoreReaderButton.Size = new Size(456, 49);
            MoreReaderButton.TabIndex = 15;
            MoreReaderButton.Text = "Открыть страницу читателя";
            MoreReaderButton.UseVisualStyleBackColor = true;
            // 
            // LendButton
            // 
            LendButton.Location = new Point(188, 528);
            LendButton.Margin = new Padding(3, 4, 3, 4);
            LendButton.Name = "LendButton";
            LendButton.Size = new Size(456, 49);
            LendButton.TabIndex = 16;
            LendButton.Text = "Выдать книгу";
            LendButton.UseVisualStyleBackColor = true;
            LendButton.Click += LendButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 315);
            label3.Name = "label3";
            label3.Size = new Size(339, 20);
            label3.TabIndex = 17;
            label3.Text = "//Выбрать книгу видно, если книга не выбрана";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 353);
            label4.Name = "label4";
            label4.Size = new Size(414, 20);
            label4.TabIndex = 18;
            label4.Text = "//Открыть страницу книги будет когда книга уже выбрана";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(422, 315);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 19;
            label5.Text = "//Аналогично";
            // 
            // LendForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label3;
        private Label label4;
        private Label label5;
    }
}