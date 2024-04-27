namespace biblaoteka
{
    partial class AuthorizationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            UserNameLabel = new Label();
            PasswordLabel = new Label();
            WelcomeLabel = new Label();
            SuspendLayout();
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(315, 140);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(183, 23);
            UserNameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(315, 181);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(183, 23);
            PasswordTextBox.TabIndex = 1;
            PasswordTextBox.KeyDown += PasswordTextBox_KeyDown;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(314, 265);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(184, 79);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Далее";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameLabel.Location = new Point(147, 138);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(145, 21);
            UserNameLabel.TabIndex = 3;
            UserNameLabel.Text = "Имя пользователя:";
            UserNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(226, 179);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(66, 21);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Пароль:";
            PasswordLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(355, 54);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(91, 37);
            WelcomeLabel.TabIndex = 5;
            WelcomeLabel.Text = "Войти";
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(WelcomeLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UserNameLabel);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Name = "AuthorizationForm";
            Text = "Библиотека - Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Label UserNameLabel;
        private Label PasswordLabel;
        private Label WelcomeLabel;
    }
}