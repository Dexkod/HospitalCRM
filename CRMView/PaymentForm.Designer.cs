namespace CRMView
{
    partial class PaymentForm
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
            this.PayButton = new System.Windows.Forms.Button();
            this.PricePerOneLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.AllPricyMedicationLabel = new System.Windows.Forms.Label();
            this.TextAllSumLabel = new System.Windows.Forms.Label();
            this.NumberAllSumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(694, 409);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(94, 29);
            this.PayButton.TabIndex = 0;
            this.PayButton.Text = "Оплатить";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // PricePerOneLabel
            // 
            this.PricePerOneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PricePerOneLabel.Location = new System.Drawing.Point(194, 9);
            this.PricePerOneLabel.Name = "PricePerOneLabel";
            this.PricePerOneLabel.Size = new System.Drawing.Size(157, 42);
            this.PricePerOneLabel.TabIndex = 2;
            this.PricePerOneLabel.Text = "Цена";
            this.PricePerOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(176, 42);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Название";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountLabel
            // 
            this.CountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountLabel.Location = new System.Drawing.Point(357, 9);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(201, 42);
            this.CountLabel.TabIndex = 4;
            this.CountLabel.Text = "Количество";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllPricyMedicationLabel
            // 
            this.AllPricyMedicationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllPricyMedicationLabel.Location = new System.Drawing.Point(564, 9);
            this.AllPricyMedicationLabel.Name = "AllPricyMedicationLabel";
            this.AllPricyMedicationLabel.Size = new System.Drawing.Size(224, 42);
            this.AllPricyMedicationLabel.TabIndex = 5;
            this.AllPricyMedicationLabel.Text = "Общая сумма";
            this.AllPricyMedicationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextAllSumLabel
            // 
            this.TextAllSumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextAllSumLabel.Location = new System.Drawing.Point(12, 399);
            this.TextAllSumLabel.Name = "TextAllSumLabel";
            this.TextAllSumLabel.Size = new System.Drawing.Size(176, 42);
            this.TextAllSumLabel.TabIndex = 6;
            this.TextAllSumLabel.Text = "Всего к оплате:";
            this.TextAllSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberAllSumLabel
            // 
            this.NumberAllSumLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberAllSumLabel.Location = new System.Drawing.Point(194, 399);
            this.NumberAllSumLabel.Name = "NumberAllSumLabel";
            this.NumberAllSumLabel.Size = new System.Drawing.Size(285, 42);
            this.NumberAllSumLabel.TabIndex = 7;
            this.NumberAllSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumberAllSumLabel);
            this.Controls.Add(this.TextAllSumLabel);
            this.Controls.Add(this.AllPricyMedicationLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PricePerOneLabel);
            this.Controls.Add(this.PayButton);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button PayButton;
        private Label PricePerOneLabel;
        private Label NameLabel;
        private Label CountLabel;
        private Label AllPricyMedicationLabel;
        private Label TextAllSumLabel;
        private Label NumberAllSumLabel;
    }
}