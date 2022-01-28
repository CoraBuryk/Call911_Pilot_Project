using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartScreen.Login
{
    [Serializable]
    public class PasswordLenghtException : ArgumentException
    {
        public PasswordLenghtException() { }
        public PasswordLenghtException(string message) : base(message) { }
        public PasswordLenghtException(string message, Exception inner) : base(message, inner) { }
        protected PasswordLenghtException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
