using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Controllers
{
    public static class ControllerPassword
    {
        public static string PasswordEncryption(string password)
        {
            StringBuilder passwordEncryption = new StringBuilder("");
            for (int i = 0; i < password.Length; i++)
            {
                if(i % 2 == 0)
                {
                    passwordEncryption.Append(Convert.ToChar(password[i] + 4));
                }
                else
                {
                    passwordEncryption.Append(Convert.ToChar(password[i] + 1));
                }
            }

            return passwordEncryption.ToString();
        }

        public static string PasswordDecoding(string passwordEncryption)
        {
            StringBuilder password = new StringBuilder("");
            for(int i = 0; i < passwordEncryption.Length; i++)
            {
                if(i % 2 == 0)
                {
                    password.Append(Convert.ToChar(passwordEncryption[i] - 4));
                }
                else
                {
                    password.Append(Convert.ToChar(passwordEncryption[i] - 1));
                }
            }

            return password.ToString();
        }
    }
}