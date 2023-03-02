using Controllers;
using HospitalCRM.Model;
using Hospitals.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMView
{
    public partial class PasswordRecoveryForm : Form
    {
        private Form authorization;
        private IEnumerable<Person> people;
        public PasswordRecoveryForm(IEnumerable<Person> people, Form authorization)
        {
            this.people = people;
            InitializeComponent();
            this.authorization = authorization;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Person human = people.FirstOrDefault(x => x.Login == LoginTextBox.Text);


            if (human == default)
            {
                MessageBox.Show("Такого логина не существует", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (!Controllers.ControllerValidation.IsValidationNullString(LoginTextBox.Text, PhoneTextBox.Text, PasswordTextBox.Text, RepeatPasswordTextBox.Text))
            {
                MessageBox.Show("Заполните все строки", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (human.Phone.Equals(PhoneTextBox.Text))
            {
                MessageBox.Show("Номер введен неверно", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (PasswordTextBox.Text.Length < 7)
            {
                MessageBox.Show("Пароль должен содержать минимум 7 символов", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (!PasswordTextBox.Text.Equals(RepeatPasswordTextBox.Text))
            {
                MessageBox.Show("Вы ввели разные пароли", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                human.Password = ControllerPassword.PasswordEncryption(PasswordTextBox.Text);
                LogInToYourAccount(human);
                Repository.Context.SaveChangesAsync();
            }
        }

        private void LogInToYourAccount(Person person)
        {
            AccountInfoForm accountInfo = new AccountInfoForm(person);
            this.Hide();
            authorization.Hide();
            accountInfo.Show();
        }
    }
}
