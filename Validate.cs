using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyBankApp
{
    public class Validate
    {
        public static bool IsValidName(string item)
        {
            // Name must begin with capital letters
            //  char[] itemArray = item.ToCharArray();
            //  if (itemArray[0] = Char.ToLower(itemArray[0]))
            //  {
            //      return true;
            //  }

            string pattern = @"^[A-Z][a-zA-Z]*$";
            return Regex.IsMatch(item, pattern);
        }

        public static bool IsValidEmail(string item)
        {
            // Simple email validation pattern
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            return Regex.IsMatch(item, pattern);
        }

        public static bool IsValidPassword(string item)
        {
            // Password should contain a minimum of 6 alphanumeric and special characters
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$";
            return Regex.IsMatch(item, pattern);
        }
    }

}
