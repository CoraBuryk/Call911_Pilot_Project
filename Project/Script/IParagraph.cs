using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Script
{
    internal interface IParagraph
    {
        string TextDial { get; set; } //Method for text part dialogues

        enum Location
        {
            house,
            yard,
            bedroom,
            basement,
            kitchen,
            attic
        }
    }
}
