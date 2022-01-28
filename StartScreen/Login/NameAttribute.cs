using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartScreen.Login
{
    public class NameAttribute : Attribute
    {
        private const int MinLenghtName = 2;
        private const int MaxLenghtName = 10;
        public NameAttribute()
        {

        }

        public bool Match(object value)
        {
            if (value != null && value.ToString().Length >= MinLenghtName && value.ToString().Length <= MaxLenghtName)
                return false;

            return true;
        }

        public virtual string FormatErrorMessage(string message)
        {
            return message;
        }
    }
}
