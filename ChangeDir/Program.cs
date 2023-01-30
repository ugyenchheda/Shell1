using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeDir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo parent = new DirectoryInfo(@"C:\Users\lenevo");

            foreach (DirectoryInfo child in parent.GetDirectories())
            {
                string newName = child.FullName.Replace('_', '-');

                if (newName != child.FullName)
                {
                    child.MoveTo(newName);
                }
            }
            Console.WriteLine("Hello world");
        }
    }
}
