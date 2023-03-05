namespace CRMView
{
    partial class CardForm
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
            this.RequisitesLabel = new System.Windows.Forms.Label();
            this.RequisitesTextBox = new System.Windows.Forms.TextBox();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.ExpirationDateTextBox = new System.Windows.Forms.TextBox();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.CVVTextBox = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequisitesLabel
            // 
            this.RequisitesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RequisitesLabel.Location = new System.Drawing.Point(104, 25);
            this.RequisitesLabel.Name = "RequisitesLabel";
            this.RequisitesLabel.Size = new System.Drawing.Size(133, 46);
            this.RequisitesLabel.TabIndex = 0;
            this.RequisitesLabel.Text = "Реквизиты";
            this.RequisitesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RequisitesTextBox
            // 
            this.RequisitesTextBox.Location = new System.Drawing.Point(117, 74);
            this.RequisitesTextBox.Name = "RequisitesTextBox";
            this.RequisitesTextBox.Size = new System.Drawing.Size(324, 27);
            this.RequisitesTextBox.TabIndex = 1;
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpirationDateLabel.Location = new System.Drawing.Point(117, 104);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(114, 43);
            this.ExpirationDateLabel.TabIndex = 2;
            this.ExpirationDateLabel.Text = "Срок годности";
            this.ExpirationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExpirationDateTextBox
            // 
            this.ExpirationDateTextBox.Location = new System.Drawing.Point(231, 112);
            this.ExpirationDateTextBox.Name = "ExpirationDateTextBox";
            this.ExpirationDateTextBox.Size = new System.Drawing.Size(69, 27);
            this.ExpirationDateTextBox.TabIndex = 3;
            this.ExpirationDateTextBox.Text = " ";
            this.ExpirationDateTextBox.TextChanged += new System.EventHandler(this.ExpirationDateTextBox_TextChanged);
            // 
            // CVVLabel
            // 
            this.CVVLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CVVLabel.Location = new System.Drawing.Point(306, 104);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(66, 43);
            this.CVVLabel.TabIndex = 4;
            this.CVVLabel.Text = "CVV";
            this.CVVLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CVVTextBox
            // 
            this.CVVTextBox.Location = new System.Drawing.Point(378, 112);
            this.CVVTextBox.Name = "CVVTextBox";
            this.CVVTextBox.Size = new System.Drawing.Size(63, 27);
            this.CVVTextBox.TabIndex = 5;
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(449, 198);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(94, 29);
            this.PayButton.TabIndex = 6;
            this.PayButton.Text = "Оплата";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 239);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.CVVTextBox);
            this.Controls.Add(this.CVVLabel);
            this.Controls.Add(this.ExpirationDateTextBox);
            this.Controls.Add(this.ExpirationDateLabel);
            this.Controls.Add(this.RequisitesTextBox);
            this.Controls.Add(this.RequisitesLabel);
            this.Name = "CardForm";
            this.Text = "CardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label RequisitesLabel;
        private TextBox RequisitesTextBox;
        private Label ExpirationDateLabel;
        private TextBox ExpirationDateTextBox;
        private Label CVVLabel;
        private TextBox CVVTextBox;
        private Button PayButton;
    }
}