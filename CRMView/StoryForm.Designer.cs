namespace CRMView
{
    partial class StoryForm
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
            this.HistoryRecordButton = new System.Windows.Forms.Button();
            this.RecordButton = new System.Windows.Forms.Button();
            this.PharmacyButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.CardButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MedicationLabel = new System.Windows.Forms.Label();
            this.NextMedicationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryRecordButton
            // 
            this.HistoryRecordButton.Location = new System.Drawing.Point(1, 172);
            this.HistoryRecordButton.Name = "HistoryRecordButton";
            this.HistoryRecordButton.Size = new System.Drawing.Size(130, 60);
            this.HistoryRecordButton.TabIndex = 5;
            this.HistoryRecordButton.Text = "История записей";
            this.HistoryRecordButton.UseVisualStyleBackColor = true;
            // 
            // RecordButton
            // 
            this.RecordButton.Location = new System.Drawing.Point(1, 122);
            this.RecordButton.Name = "RecordButton";
            this.RecordButton.Size = new System.Drawing.Size(130, 55);
            this.RecordButton.TabIndex = 6;
            this.RecordButton.Text = "Запись";
            this.RecordButton.UseVisualStyleBackColor = true;
            // 
            // PharmacyButton
            // 
            this.PharmacyButton.Location = new System.Drawing.Point(1, 68);
            this.PharmacyButton.Name = "PharmacyButton";
            this.PharmacyButton.Size = new System.Drawing.Size(130, 57);
            this.PharmacyButton.TabIndex = 4;
            this.PharmacyButton.Text = "Аптека";
            this.PharmacyButton.UseVisualStyleBackColor = true;
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(1, 0);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(130, 71);
            this.AccountButton.TabIndex = 3;
            this.AccountButton.Text = "Главная";
            this.AccountButton.UseVisualStyleBackColor = true;
            // 
            // CardButton
            // 
            this.CardButton.Location = new System.Drawing.Point(1, 390);
            this.CardButton.Name = "CardButton";
            this.CardButton.Size = new System.Drawing.Size(130, 48);
            this.CardButton.TabIndex = 7;
            this.CardButton.Text = "перейти в корзину";
            this.CardButton.UseVisualStyleBackColor = true;
            this.CardButton.Click += new System.EventHandler(this.CardButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(657, 12);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(111, 32);
            this.FilterButton.TabIndex = 8;
            this.FilterButton.Text = "Фильтр";
            this.FilterButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(225, 68);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(187, 27);
            this.SearchTextbox.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(418, 65);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(88, 32);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // MedicationLabel
            // 
            this.MedicationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedicationLabel.Location = new System.Drawing.Point(137, 138);
            this.MedicationLabel.Name = "MedicationLabel";
            this.MedicationLabel.Size = new System.Drawing.Size(663, 39);
            this.MedicationLabel.TabIndex = 11;
            this.MedicationLabel.Text = "Препараты";
            this.MedicationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextMedicationButton
            // 
            this.NextMedicationButton.Location = new System.Drawing.Point(670, 409);
            this.NextMedicationButton.Name = "NextMedicationButton";
            this.NextMedicationButton.Size = new System.Drawing.Size(118, 29);
            this.NextMedicationButton.TabIndex = 15;
            this.NextMedicationButton.Text = "Следующие";
            this.NextMedicationButton.UseVisualStyleBackColor = true;
            this.NextMedicationButton.Click += new System.EventHandler(this.NextMedicationButton_Click);
            // 
            // StoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextMedicationButton);
            this.Controls.Add(this.MedicationLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.CardButton);
            this.Controls.Add(this.HistoryRecordButton);
            this.Controls.Add(this.RecordButton);
            this.Controls.Add(this.PharmacyButton);
            this.Controls.Add(this.AccountButton);
            this.Name = "StoryForm";
            this.Text = "StoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button HistoryRecordButton;
        private Button RecordButton;
        private Button PharmacyButton;
        private Button AccountButton;
        private Button CardButton;
        private Button FilterButton;
        private TextBox SearchTextbox;
        private Button SearchButton;
        private Label MedicationLabel;
        private Button NextMedicationButton;
    }
}