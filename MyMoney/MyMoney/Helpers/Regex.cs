﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyMoney.Helpers
{
    internal class RegexHelpers
    {
        public static bool ContainsNonCharacters(TextBox text)
        {
            Regex regex = new Regex(@"[^a-zA-Z]");
            return regex.IsMatch(text.Text);
        }

        public static bool PasswordValidator(TextBox password)
        {
            if (password.Text.Length < 8) return false;
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+=\-[\]{};':""\\|,.<>\/?]).+$");
            return regex.IsMatch(password.Text);
        }

        public static bool EmailValidator(TextBox email)
        {
            if (email == null) return false;
            Regex regex = new Regex(@"^[a-z0-9]+(\.[a-z0-9]+)*@[a-z0-9-]+\.(com|org|net|edu|gov|io|co)$");
            return regex.IsMatch(email.Text);
        }
    }
}
