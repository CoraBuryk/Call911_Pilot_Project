using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StartScreen
{
    public class InfoAboutAssembly
    {
        [Temporary]
        public void Get()
        {
            string text = null;
            using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + $"\\AssamblyInfoStartScreen.txt", true))
            {
                Assembly a = Assembly.GetEntryAssembly();
                foreach (var i in a.GetReferencedAssemblies())
                {
                    sw.WriteLine(i.FullName);
                }

                Type[] typelist = Assembly.GetExecutingAssembly().GetTypes();
                foreach (Type cl in typelist)
                {
                    sw.WriteLine("");
                    sw.WriteLine(cl.Name);
                    sw.WriteLine("**************************************************************************");
                    MethodInfo[] mi = cl.GetMethods(BindingFlags.Instance
                       | BindingFlags.Static
                       | BindingFlags.Public
                       | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

                    foreach (var tt in mi)
                    {
                        text = tt.Name;
                    }

                    text = "";
                }

                sw.WriteLine(text);
                sw.Dispose();
                sw.Close();

                TemporaryAttribute.DeleteTmpFile(sw.ToString());
            }

        }
    }
}
