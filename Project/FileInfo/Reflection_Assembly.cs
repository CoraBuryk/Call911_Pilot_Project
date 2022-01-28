using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project.Script
{
    public class Reflection_Assembly
    {
        //get reflection for Project.exe with infornation about Referenced Assamblies and Method Info 
        [Temporary]
        public void GetInfo()
        {
            string text = null;
            using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + $"\\AssamblyInfoProject.txt", true))
            {
                Assembly a = Assembly.GetEntryAssembly();
                foreach (var i in a.GetReferencedAssemblies())
                {
                    Console.WriteLine(i.FullName);
                    sw.WriteLine(i.FullName);
                }

                Type[] typelist = Assembly.GetExecutingAssembly().GetTypes();
                foreach (Type cl in typelist)
                {
                    Console.WriteLine("");
                    sw.WriteLine("");
                    Console.WriteLine(cl.Name);
                    sw.WriteLine(cl.Name);
                    Console.WriteLine("**************************************************************************");
                    sw.WriteLine("**************************************************************************");
                    MethodInfo[] mi = cl.GetMethods(BindingFlags.Instance
                       | BindingFlags.Static
                       | BindingFlags.Public
                       | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);

                    foreach (var tt in mi)
                    {
                        text = tt.Name;
                        Console.WriteLine(text);
                        sw.WriteLine(text);
                    }
                    text = "";
                    Console.WriteLine(text);
                    sw.WriteLine(text);
                }
                sw.Dispose();
                sw.Close();

                TemporaryAttribute.DeleteTmpFile(sw.ToString());
            }
        }
    }
}
