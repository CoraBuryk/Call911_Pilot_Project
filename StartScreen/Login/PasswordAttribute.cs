using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace StartScreen.Login
{
    public class PasswordAttribute : ValidationAttribute
    {
        private const int MaxLenghtName = 8;
        public PasswordAttribute()
        {

        }
        public override bool IsValid(object value)
        {
            if (value != null && value.ToString().Length == MaxLenghtName)
                return false;

            return true;
        }
        public virtual string FormatErrorMessage(string message)
        {
            return message;
        }
    }
}
