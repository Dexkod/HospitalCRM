namespace CRMView
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.ForgetPasswordLabel = new System.Windows.Forms.Label();
            this.EntranceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(251, 29);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(279, 77);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Вход в учетную запись";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(300, 170);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(161, 27);
            this.LoginTextBox.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLabel.Location = new System.Drawing.Point(318, 133);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(121, 34);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(318, 214);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(121, 34);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(300, 251);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(161, 27);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RegistrationLabel.Location = new System.Drawing.Point(599, 398);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(157, 30);
            this.RegistrationLabel.TabIndex = 5;
            this.RegistrationLabel.Text = "Зарегистрироваться";
            this.RegistrationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegistrationLabel.Click += new System.EventHandler(this.RegistrationLabel_Click);
            // 
            // ForgetPasswordLabel
            // 
            this.ForgetPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForgetPasswordLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ForgetPasswordLabel.Location = new System.Drawing.Point(300, 281);
            this.ForgetPasswordLabel.Name = "ForgetPasswordLabel";
            this.ForgetPasswordLabel.Size = new System.Drawing.Size(157, 30);
            this.ForgetPasswordLabel.TabIndex = 6;
            this.ForgetPasswordLabel.Text = "Забыли пароль?";
            this.ForgetPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForgetPasswordLabel.Click += new System.EventHandler(this.ForgetPasswordLabel_Click);
            // 
            // EntranceButton
            // 
            this.EntranceButton.Location = new System.Drawing.Point(332, 341);
            this.EntranceButton.Name = "EntranceButton";
            this.EntranceButton.Size = new System.Drawing.Size(94, 29);
            this.EntranceButton.TabIndex = 7;
            this.EntranceButton.Text = "Войти";
            this.EntranceButton.UseVisualStyleBackColor = true;
            this.EntranceButton.Click += new System.EventHandler(this.EntranceButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EntranceButton);
            this.Controls.Add(this.ForgetPasswordLabel);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.InfoLabel);
            this.Name = "AuthorizationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InfoLabel;
        private TextBox LoginTextBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label RegistrationLabel;
        private Label ForgetPasswordLabel;
        private Button EntranceButton;
    }
}