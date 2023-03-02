namespace CRMView
{
    partial class PasswordRecoveryForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(268, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(258, 57);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Введите свой Логин ";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(302, 69);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(149, 27);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(302, 170);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(149, 27);
            this.PhoneTextBox.TabIndex = 3;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneLabel.Location = new System.Drawing.Point(255, 110);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(271, 57);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Введите свой  телефон";
            this.PhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(302, 274);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(149, 27);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(200, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите свой новый пароль";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(302, 374);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '*';
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(149, 27);
            this.RepeatPasswordTextBox.TabIndex = 7;
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(200, 314);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(396, 57);
            this.RepeatPasswordLabel.TabIndex = 6;
            this.RepeatPasswordLabel.Text = "Повторите пароль";
            this.RepeatPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(652, 400);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 29);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.InfoLabel);
            this.Name = "PasswordRecovery";
            this.Text = "PasswordRecovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InfoLabel;
        private TextBox LoginTextBox;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox PasswordTextBox;
        private Label label2;
        private TextBox RepeatPasswordTextBox;
        private Label RepeatPasswordLabel;
        private Button SaveButton;
    }
}