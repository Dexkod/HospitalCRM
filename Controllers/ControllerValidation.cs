

namespace Controllers
{
    public static class ControllerValidation
    {
        public static bool IsLineNumbers(params string[] items)
        {
            foreach(var item in items)
            {
                foreach (var letter in item)
                {
                    if (letter < '0' || letter > '9')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public static bool IsValidationLineLetter(params string[] items)
        {
            foreach (var item in items)
            {
                foreach (var letter in item)
                {
                    if (!(letter >= 'a' && letter <= 'z') &&
                        !(letter >= 'A' && letter <= 'Z') &&
                        !(letter >= 'а' && letter <= 'я') &&
                        !(letter >= 'А' && letter <= 'Я'))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool IsValidationNullString(params string[] items)
        {
            foreach (string item in items)
            {
                if (string.IsNullOrEmpty(item) || item.Contains(" "))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
