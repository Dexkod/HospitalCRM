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
            this.FillCardButton = new System.Windows.Forms.Button();
            this.PricePerOneLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CountLabel = new System.Windows.Forms.Label();
            this.AllPricyMedicationLabel = new System.Windows.Forms.Label();
            this.TextAllSumLabel = new System.Windows.Forms.Label();
            this.NumberAllSumLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // FillCardButton
            // 
            this.FillCardButton.Location = new System.Drawing.Point(564, 409);
            this.FillCardButton.Name = "FillCardButton";
            this.FillCardButton.Size = new System.Drawing.Size(118, 29);
            this.FillCardButton.TabIndex = 1;
            this.FillCardButton.Text = "Ваша карта";
            this.FillCardButton.UseVisualStyleBackColor = true;
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
            this.CountLabel.Click += new System.EventHandler(this.label3_Click);
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
            this.NumberAllSumLabel.Size = new System.Drawing.Size(258, 42);
            this.NumberAllSumLabel.TabIndex = 7;
            this.NumberAllSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(205, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(620, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(407, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(102, 27);
            this.numericUpDown1.TabIndex = 11;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberAllSumLabel);
            this.Controls.Add(this.TextAllSumLabel);
            this.Controls.Add(this.AllPricyMedicationLabel);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PricePerOneLabel);
            this.Controls.Add(this.FillCardButton);
            this.Controls.Add(this.PayButton);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button PayButton;
        private Button FillCardButton;
        private Label PricePerOneLabel;
        private Label NameLabel;
        private Label CountLabel;
        private Label AllPricyMedicationLabel;
        private Label TextAllSumLabel;
        private Label NumberAllSumLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}