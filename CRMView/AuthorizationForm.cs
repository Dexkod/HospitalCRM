using Controllers;
using HospitalCRM.Model;
using Hospitals.Data;

namespace CRMView
{
    public partial class AuthorizationForm : Form
    {
        private IEnumerable<Person> people;
        private static Person Human;
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
        public AuthorizationForm()
        {
            GetpeopleAsync();
            Controls.Add(labelMessageError);
            InitializeComponent();
        }

        private async Task GetpeopleAsync()
        {
            people = await Repository.Context.GetPersons();
        }

        private void RegistrationLabel_Click(object sender, EventArgs e)
        {
            if(people != null)
            {
                var registration = new RegistrationForm(people, this);
                if (registration.ShowDialog() == DialogResult.OK)
                {
                    LogInToYourAccount(Human);
                }
            }
            else
            {
                MessageBox.Show("Загрузка займет время попробуйте через некоторое время", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void EntranceButton_Click(object sender, EventArgs e)
        {
            if (people != null)
            {
                Human = people.FirstOrDefault(x => x.Login != null && x.Login.Equals(LoginTextBox.Text));
                if (Human != default && ControllerPassword.PasswordDecoding(Human.Password).Equals(PasswordTextBox.Text))
                {
                    LogInToYourAccount(Human);
                }
                else
                {
                    labelMessageError.Text = "Неправильный логин или пароль";
                }
            }
            else
            {
                MessageBox.Show("Загрузка займет время попробуйте через некоторое время", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LogInToYourAccount(Person person)
        {
            AccountInfoForm accountInfo = new AccountInfoForm(person);
            this.Hide();
            accountInfo.Show();
        }

        private void ForgetPasswordLabel_Click(object sender, EventArgs e)
        {
            if (people != null)
            {
                var passwordRecoveryForm = new PasswordRecoveryForm(people, this);
                if (passwordRecoveryForm.ShowDialog() == DialogResult.OK)
                {
                    LogInToYourAccount(Human);
                }
            }
            else
            {
                MessageBox.Show("Загрузка займет время попробуйте через некоторое время", "Загрузка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}