using Controllers;
using Hospital;
using HospitalCRM.Model;
using Hospitals.Data;
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
    public partial class AccountInfoForm : Form
    {
        private Person person;
        private Button buttonSave;
        private Button buttonBack;
        private TextBox textBoxChange;
        public AccountInfoForm(Person person)
        {
            this.person = person;
            InitializeComponent();
            NumberLabel.Text = person.Phone.ToString();
            LoginLabel.Text = person.Login;
            LastNameLabel.Text = person.LastName;
            NameLabel.Text = person.Name;
        }


        private void AccountInfo_Load(object sender, EventArgs e)
        {

        }

        private void ChangeLastNameLabel_Click(object sender, EventArgs e)
        {
            int flag = 2;
            if(textBoxChange == default)
            {
                CreateTextBox(LastNameLabel.Location.X, LastNameLabel.Location.Y, LastNameLabel.Size.Width, LastNameLabel.Size.Height, flag);
            }
            else if(!ControllerValidation.IsValidationNullString(textBoxChange.Text) || !ControllerValidation.IsValidationLineLetter(textBoxChange.Text))
            {
                MessageBox.Show("Неправильный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxChange = null;
            }
            else
            {
                person.LastName = textBoxChange.Text;
                LastNameLabel.Text= textBoxChange.Text;
                Repository.Context.SaveChangesAsync();
                textBoxChange = null;
            }
        }

        private void CreateTextBox(int x, int y, int width, int height, int flag)
        {
            textBoxChange = new TextBox()
            {
                Location = new System.Drawing.Point(x, y),
                Name = "textBox1",
                Size = new System.Drawing.Size(width, height),
                TabIndex = 20
            };
            buttonSave = new Button()
            {
                Location = new System.Drawing.Point(x, y + height),
                Text = "Сохранить",
                Name = "buttonSave" + flag.ToString(),
                Size = new System.Drawing.Size(width / 2, height),
            };
            buttonBack = new Button()
            {
                Location = new System.Drawing.Point(x + width / 2, y + height),
                Text = "Назад",
                Name = "buttonBack",
                Size = new System.Drawing.Size(width / 2, height),
            };

            buttonSave.Click += new System.EventHandler(buttonSave_Click);
            buttonBack.Click += new System.EventHandler(buttonBack_Click);
            Controls.Add(textBoxChange);
            Controls.Add(buttonSave);
            Controls.Add(buttonBack);
            buttonBack.BringToFront();
            buttonSave.BringToFront();
            textBoxChange.BringToFront();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DeleteControls();
            textBoxChange = null;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DeleteControls();
            int flag = Convert.ToInt32(buttonSave.Name[buttonSave.Name.Length - 1].ToString());

            switch (flag)
            {
                case 1:
                    ChangeNameLabel_Click(sender, e);
                    break;
                case 2:
                    ChangeLastNameLabel_Click(sender, e);
                    break;
                case 3:
                    ChangeLoginLabel_Click(sender, e);
                    break;
                case 4:
                    ChangePhoneLabel_Click(sender, e);
                    break;
            }
        }
        private void DeleteControls()
        {
            Controls.RemoveByKey(textBoxChange.Name);
            Controls.RemoveByKey(buttonBack.Name);
            Controls.RemoveByKey(buttonSave.Name);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void ChangeNameLabel_Click(object sender, EventArgs e)
        {
            int flag = 1;
            if (textBoxChange == default)
            {
                CreateTextBox(NameLabel.Location.X, NameLabel.Location.Y, NameLabel.Size.Width, NameLabel.Size.Height, flag);
            }
            else if (!ControllerValidation.IsValidationNullString(textBoxChange.Text) || !ControllerValidation.IsValidationLineLetter(textBoxChange.Text))
            {
                MessageBox.Show("Неправильный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxChange = null;
            }
            else
            {
                person.Name = textBoxChange.Text;
                NameLabel.Text = textBoxChange.Text;
                Repository.Context.SaveChangesAsync();
                textBoxChange = null;
            }
        }

        private void ChangeLoginLabel_Click(object sender, EventArgs e)
        {
            int flag = 3;
            if (textBoxChange == default)
            {
                CreateTextBox(LoginLabel.Location.X, LoginLabel.Location.Y, LoginLabel.Size.Width, LoginLabel.Size.Height, flag);
            }
            else if (!ControllerValidation.IsValidationNullString(textBoxChange.Text))
            {
                MessageBox.Show("Неправильный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxChange = null;
            }
            else
            {
                person.Login = textBoxChange.Text;
                LoginLabel.Text = textBoxChange.Text;
                Repository.Context.SaveChangesAsync();
                textBoxChange = null;
            }
        }

        private void ChangePhoneLabel_Click(object sender, EventArgs e)
        {
            int flag = 4;
            if (textBoxChange == default)
            {
                CreateTextBox(NumberLabel.Location.X, NumberLabel.Location.Y, NumberLabel.Size.Width, NumberLabel.Size.Height, flag);
            }
            else if (!(textBoxChange.Text.Length == 11) || !ControllerValidation.IsLineNumbers(textBoxChange.Text))
            {
                MessageBox.Show("Неправильный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxChange = null;
            }
            else
            {
                person.Phone = long.Parse(textBoxChange.Text);
                NumberLabel.Text = textBoxChange.Text;
                Repository.Context.SaveChangesAsync();
                textBoxChange = null;
            }
        }

        private async void PharmacyButton_Click(object sender, EventArgs e)
        {

            var medications = await Repository.Context.GetMedications();
            if (medications == null)
            {
                MessageBox.Show("Аптека прогружается повторите попытку через несколько секунд", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                StoryForm storyForm = new StoryForm(person, medications.ToList());
                storyForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditPhotoLabel_Click(object sender, EventArgs e)
        {
            //ToDo
        }


    }
}
