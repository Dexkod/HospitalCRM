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
    public partial class Registration : Form
    {
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
        public Registration()
        {
            Controls.Add(labelMessageError);
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var people = await Repository.Context.GetPersons();
            if (!ControllerValidation.IsValidationNullString(textBox1.Text, textBox2.Text, textBox3.Text, 
                textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text))
            {
                labelMessageError.Text = "Заполните все строки";
            }
            else if (!ControllerValidation.IsValidationLineLetter(textBox1.Text, textBox2.Text))
            {
                labelMessageError.Text = "Вы ввели неправильное имя или фамилию";
            }
            else if (!ControllerValidation.IsLineNumbers(textBox3.Text) || 
                !(int.Parse(textBox3.Text) >= 14 && int.Parse(textBox3.Text) <= 120))
            {
                labelMessageError.Text = "Неправильный ввод возраста";
            }
            else if (!textBox5.Text.Equals(textBox6.Text) || textBox5.Text.Length < 8)
            {
                labelMessageError.Text = "Вы ввели некорректный пароль";
            }
            else if (people.Where(x => x.Login != null).Any(x => x.Login.Equals(textBox4.Text)))
            {
                labelMessageError.Text = "Пользователь с таким логином уже существует";
            }
            else if (!ControllerValidation.IsLineNumbers(textBox7.Text) || textBox7.Text.Length < 10)
            {
                labelMessageError.Text = "Вы ввели неправильный номер";
            }
            else if (labelMessageError.Text.Length > 1)
            {
                labelMessageError.Text = "";
                await Repository.Context.Add(new Person(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text),
                    textBox4.Text, ControllerPassword.PasswordEncryption(textBox5.Text), int.Parse(textBox7.Text)));
            }
            

        }




    }
}
