using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using HospitalCRM;
using HospitalCRM.Model;
using Hospitals.Data;

namespace CRMView
{
    public partial class RegistrationForm : Form
    {
        private Form authorization;
        private IEnumerable<Person> people;
        private Label labelMessageError = new Label()
        {
            Location = new Point(200, 398),
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point),
            ForeColor = Color.Red,
            Text = "",
            AutoSize = false,
            Size = new System.Drawing.Size(400, 30),
            TextAlign = ContentAlignment.MiddleCenter
        };
        public RegistrationForm(IEnumerable<Person> people, Form authorization)
        {
            this.people = people;
            Controls.Add(labelMessageError);
            InitializeComponent();
            this.authorization = authorization;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (!ControllerValidation.IsValidationNullString(NameTextBox.Text, LastNameTextBox.Text, AgeTextBox.Text, 
                LoginTextBox.Text, PasswordTextBox.Text, RepeatPasswordTextBox.Text, PhoneTextBox.Text))
            {
                labelMessageError.Text = "Заполните все строки";
            }
            else if (!ControllerValidation.IsValidationLineLetter(NameTextBox.Text, LastNameTextBox.Text))
            {
                labelMessageError.Text = "Вы ввели неправильное имя или фамилию";
            }
            else if (!ControllerValidation.IsLineNumbers(AgeTextBox.Text) || 
                !(int.Parse(AgeTextBox.Text) >= 14 && int.Parse(AgeTextBox.Text) <= 120))
            {
                labelMessageError.Text = "Неправильный ввод возраста";
            }
            else if (!PasswordTextBox.Text.Equals(RepeatPasswordTextBox.Text) || PasswordTextBox.Text.Length < 8)
            {
                labelMessageError.Text = "Вы ввели некорректный пароль";
            }
            else if (people.Where(x => x.Login != null).Any(x => x.Login.Equals(LoginTextBox.Text)))
            {
                labelMessageError.Text = "Пользователь с таким логином уже существует";
            }
            else if (!ControllerValidation.IsLineNumbers(PhoneTextBox.Text) || PhoneTextBox.Text.Length != 11)
            {
                labelMessageError.Text = "Вы ввели неправильный номер";
            }
            else
            {
                labelMessageError.Text = "";
                var human = new Person(NameTextBox.Text, LastNameTextBox.Text, int.Parse(AgeTextBox.Text),
                    LoginTextBox.Text, ControllerPassword.PasswordEncryption(PasswordTextBox.Text), Convert.ToInt64(PhoneTextBox.Text));
                Repository.Context.Add(human);
                LogInToYourAccount(human);
                
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
