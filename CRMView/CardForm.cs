using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMView
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if(!ControllerValidation.IsValidationLineLetter(RequisitesTextBox.Text) && 
                RequisitesTextBox.Text.Where(x => x != ' ').Count() != 16)
            {
                MessageBox.Show("Неправильно введены реквизиты", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if(!ControllerValidation.IsLineNumbers(ExpirationDateTextBox.Text.Replace('/','9').Replace(' ', '0')) || 
                !ExpirationDateTextBox.Text.Contains("/") || DateTime.Now > Data(ExpirationDateTextBox))
            {
                MessageBox.Show("Неправильно введена срок годности", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if(!ControllerValidation.IsLineNumbers(CVVTextBox.Text) ||
                CVVTextBox.Text.Where(x => x != ' ').Count() != 3)
            {
                MessageBox.Show("Неправильно введена CVV", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private DateTime Data(TextBox data)
        {
            int mouth = 1;
            int year = 1; 
            if(int.Parse(data.Text.Split("/")[0]) <= 12)
            {
                mouth= int.Parse(data.Text.Split("/")[0]);
                year = data.Text.Split("/")[1].Length == 2 ? int.Parse("20" + data.Text.Split("/")[1]) : 1;
            }
            return new DateTime(year, mouth, 1);
        }

        private void ExpirationDateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ExpirationDateTextBox.Text.Length == 2 && !ExpirationDateTextBox.Text.Contains("/"))
            {
                ExpirationDateTextBox.Text += "/";
            }
        }
    }
}
