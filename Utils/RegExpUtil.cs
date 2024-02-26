using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils
{
    public static class RegExpUtil
    {
        private static Regex _rgxEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1));
        public static bool IsValidEmail(string email)
        {
            return _rgxEmail.IsMatch(email);
        }
    }
}
