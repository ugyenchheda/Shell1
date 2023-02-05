using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrDirec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string newFilePath = "\\\\wsl.localhost\\Ubuntu\\home\\ugyen\\OS\\Shell\\ChangeDir\\workingDir.txt";
            string pathAvai = File.ReadAllText(newFilePath);
            var newWrkDir = File.ReadAllText(newFilePath);

            if(pathAvai.Length == 0)
            {
                Console.WriteLine(Directory.GetCurrentDirectory());

            }
            else
            {
                Directory.SetCurrentDirectory(newWrkDir);
                string execPath = Directory.GetCurrentDirectory();
                Console.WriteLine(execPath);
            }
            
    }
    }
}
