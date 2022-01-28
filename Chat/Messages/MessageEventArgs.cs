using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Messages
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
