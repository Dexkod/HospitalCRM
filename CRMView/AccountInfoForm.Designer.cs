namespace CRMView
{
    partial class AccountInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HistoryRecordButton = new System.Windows.Forms.Button();
            this.RecordButton = new System.Windows.Forms.Button();
            this.PharmacyButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PhotoLabel = new System.Windows.Forms.Label();
            this.EditPhotoLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ChangePhoneLabel = new System.Windows.Forms.Label();
            this.ChangeLoginLabel = new System.Windows.Forms.Label();
            this.HistoryPurchasesLabel = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ChangeNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ChangeLastNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HistoryRecordButton);
            this.panel1.Controls.Add(this.RecordButton);
            this.panel1.Controls.Add(this.PharmacyButton);
            this.panel1.Controls.Add(this.AccountButton);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 232);
            this.panel1.TabIndex = 1;
            // 
            // HistoryRecordButton
            // 
            this.HistoryRecordButton.Location = new System.Drawing.Point(0, 172);
            this.HistoryRecordButton.Name = "HistoryRecordButton";
            this.HistoryRecordButton.Size = new System.Drawing.Size(130, 60);
            this.HistoryRecordButton.TabIndex = 2;
            this.HistoryRecordButton.Text = "История записей";
            this.HistoryRecordButton.UseVisualStyleBackColor = true;
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(0, 122);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(130, 55);
            this.RecordButton.TabIndex = 2;
            this.RecordButton.Text = "Запись";
            this.RecordButton.UseVisualStyleBackColor = true;
            // 
            // PharmacyButton
            // 
            this.PharmacyButton.Location = new System.Drawing.Point(0, 68);
            this.PharmacyButton.Name = "PharmacyButton";
            this.PharmacyButton.Size = new System.Drawing.Size(130, 57);
            this.PharmacyButton.TabIndex = 1;
            this.PharmacyButton.Text = "Аптека";
            this.PharmacyButton.UseVisualStyleBackColor = true;
            this.PharmacyButton.Click += new System.EventHandler(this.PharmacyButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(0, 0);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(130, 71);
            this.AccountButton.TabIndex = 0;
            this.AccountButton.Text = "Главная";
            this.AccountButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PhotoLabel);
            this.panel2.Location = new System.Drawing.Point(601, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 148);
            this.panel2.TabIndex = 2;
            // 
            // PhotoLabel
            // 
            this.PhotoLabel.Image = ((System.Drawing.Image)(resources.GetObject("PhotoLabel.Image")));
            this.PhotoLabel.Location = new System.Drawing.Point(0, 0);
            this.PhotoLabel.Name = "PhotoLabel";
            this.PhotoLabel.Size = new System.Drawing.Size(203, 148);
            this.PhotoLabel.TabIndex = 0;
            // 
            // EditPhotoLabel
            // 
            this.EditPhotoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditPhotoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EditPhotoLabel.Location = new System.Drawing.Point(660, 163);
            this.EditPhotoLabel.Name = "EditPhotoLabel";
            this.EditPhotoLabel.Size = new System.Drawing.Size(101, 31);
            this.EditPhotoLabel.TabIndex = 3;
            this.EditPhotoLabel.Text = "Изменить";
            this.EditPhotoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditPhotoLabel.Click += new System.EventHandler(this.EditPhotoLabel_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Location = new System.Drawing.Point(156, 109);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(174, 39);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberLabel
            // 
            this.NumberLabel.Location = new System.Drawing.Point(358, 109);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(213, 39);
            this.NumberLabel.TabIndex = 5;
            this.NumberLabel.Text = "Телефон";
            this.NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangePhoneLabel
            // 
            this.ChangePhoneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePhoneLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ChangePhoneLabel.Location = new System.Drawing.Point(416, 161);
            this.ChangePhoneLabel.Name = "ChangePhoneLabel";
            this.ChangePhoneLabel.Size = new System.Drawing.Size(101, 31);
            this.ChangePhoneLabel.TabIndex = 6;
            this.ChangePhoneLabel.Text = "Изменить";
            this.ChangePhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangePhoneLabel.Click += new System.EventHandler(this.ChangePhoneLabel_Click);
            // 
            // ChangeLoginLabel
            // 
            this.ChangeLoginLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeLoginLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ChangeLoginLabel.Location = new System.Drawing.Point(197, 161);
            this.ChangeLoginLabel.Name = "ChangeLoginLabel";
            this.ChangeLoginLabel.Size = new System.Drawing.Size(101, 31);
            this.ChangeLoginLabel.TabIndex = 7;
            this.ChangeLoginLabel.Text = "Изменить";
            this.ChangeLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeLoginLabel.Click += new System.EventHandler(this.ChangeLoginLabel_Click);
            // 
            // HistoryPurchasesLabel
            // 
            this.HistoryPurchasesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistoryPurchasesLabel.Location = new System.Drawing.Point(-2, 247);
            this.HistoryPurchasesLabel.Name = "HistoryPurchasesLabel";
            this.HistoryPurchasesLabel.Size = new System.Drawing.Size(806, 38);
            this.HistoryPurchasesLabel.TabIndex = 10;
            this.HistoryPurchasesLabel.Text = "История покупок";
            this.HistoryPurchasesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataLabel
            // 
            this.DataLabel.Location = new System.Drawing.Point(-2, 296);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(206, 45);
            this.DataLabel.TabIndex = 11;
            this.DataLabel.Text = "Дата";
            this.DataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Location = new System.Drawing.Point(204, 296);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(440, 45);
            this.InfoLabel.TabIndex = 12;
            this.InfoLabel.Text = "Информация";
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(650, 296);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(154, 45);
            this.PriceLabel.TabIndex = 13;
            this.PriceLabel.Text = "Цена";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Следующая покупка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeNameLabel
            // 
            this.ChangeNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ChangeNameLabel.Location = new System.Drawing.Point(197, 68);
            this.ChangeNameLabel.Name = "ChangeNameLabel";
            this.ChangeNameLabel.Size = new System.Drawing.Size(101, 31);
            this.ChangeNameLabel.TabIndex = 18;
            this.ChangeNameLabel.Text = "Изменить";
            this.ChangeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeNameLabel.Click += new System.EventHandler(this.ChangeNameLabel_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Location = new System.Drawing.Point(358, 16);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(213, 39);
            this.LastNameLabel.TabIndex = 16;
            this.LastNameLabel.Text = "Фамилия";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(156, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(174, 39);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChangeLastNameLabel
            // 
            this.ChangeLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeLastNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ChangeLastNameLabel.Location = new System.Drawing.Point(416, 68);
            this.ChangeLastNameLabel.Name = "ChangeLastNameLabel";
            this.ChangeLastNameLabel.Size = new System.Drawing.Size(101, 31);
            this.ChangeLastNameLabel.TabIndex = 19;
            this.ChangeLastNameLabel.Text = "Изменить";
            this.ChangeLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChangeLastNameLabel.Click += new System.EventHandler(this.ChangeLastNameLabel_Click);
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeLastNameLabel);
            this.Controls.Add(this.ChangeNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.HistoryPurchasesLabel);
            this.Controls.Add(this.ChangeLoginLabel);
            this.Controls.Add(this.ChangePhoneLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.EditPhotoLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AccountInfoForm";
            this.Text = "AccountInfo";
            this.Load += new System.EventHandler(this.AccountInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Button HistoryRecordButton;
        private Button RecordButton;
        private Button PharmacyButton;
        private Button AccountButton;
        private Panel panel2;
        private Label EditPhotoLabel;
        private Label PhotoLabel;
        private Label LoginLabel;
        private Label NumberLabel;
        private Label ChangePhoneLabel;
        private Label ChangeLoginLabel;
        private Label HistoryPurchasesLabel;
        private Label DataLabel;
        private Label InfoLabel;
        private Label PriceLabel;
        private Button button1;
        private Label ChangeNameLabel;
        private Label LastNameLabel;
        private Label NameLabel;
        private Label ChangeLastNameLabel;
    }
}