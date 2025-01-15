using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationPanel.WinApp
{
    public class PasswordValidation
    {
        public static List<char> SpecialChars = new List<char>() {'@', '_', '-', '#', '$', '?', '!'};

        public static bool LengthCheck(string password)
        {
            if (password.Length > 4)
            {
                return true;
            }
            return false;
        }

        public static bool ContainsCapitalLetterCheck(string password)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsSpecialCharCheck(string password)
        {
            foreach (char c in password)
            {
                if (SpecialChars.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsIntegerCheck(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static (bool, List<string>) IsValid(string password)
        {
            bool valid = true;
            List<string> messages = new List<string>();
            if (!LengthCheck(password))
            {
                valid = false;
                messages.Add("Password must have more than 4 characters");
            }
            if (!ContainsCapitalLetterCheck(password))
            {
                valid = false;
                messages.Add("Password must have capital letters");
            }
            if (!ContainsSpecialCharCheck(password))
            {
                valid = false;
                messages.Add($"Password must have special characters such as {String.Join(", ", SpecialChars)}");
            }
            if (!ContainsIntegerCheck(password))
            {
                valid = false;
                messages.Add("Password must have integers");
            }

            return (valid, messages);
        }
    }
}
