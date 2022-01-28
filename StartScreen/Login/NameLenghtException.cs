using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartScreen.Login
{
    [Serializable]
    public class NameLenghtException :ArgumentException
    {
        public NameLenghtException() { }
        public NameLenghtException(string message) : base(message) { }
        public NameLenghtException(string message, Exception inner) : base(message, inner) { }
        protected NameLenghtException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
