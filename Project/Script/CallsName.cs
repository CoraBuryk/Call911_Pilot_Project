using Project.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Script
{
    [Serializable]
    public class CallsName
    {
        readonly List<string> name = new List<string>(10) { "Bred", "Micheal", "Jeffery",
        "George", "Christopher", "Catherine", "Vanessa", "Esther", "Amber", "Wendy" };

        readonly List<string> lastNames = new List<string>(10) { "Rose", "Foster", "Gonzalez",
        "Porter", "Tucker", "Jackson", "Brown", "Johnson", "Garza", "Price" };

        private static Random _rand = new Random(DateTime.Now.Second);

        Logger<CallsName> logger = new();
        public CallsName()
        {

        }
        public CallsName(List<string> name, List<string> lastName)
        {
            this.name = name;
            this.lastNames = lastName;
        }
        public string Full()
        {
            string full;

            var first = name.ElementAt(_rand.Next(name.Count));
            var last = lastNames.ElementAt(_rand.Next(lastNames.Count));
            logger.Debug("Name created");
            return full = $"{first} {last}";
        }
    }
}
