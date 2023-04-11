using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChangeDir;

namespace CurrDirec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string newFilePath = "add file location here";
            string pathAvai = File.ReadAllText(newFilePath);
            var newWrkDir = File.ReadAllText(newFilePath);

            if (pathAvai.Length == 0)
            {
                Console.WriteLine(Directory.GetCurrentDirectory());
            }
            else
            {
                Directory.SetCurrentDirectory(newWrkDir);
                string execPath = Directory.GetCurrentDirectory();
                Console.WriteLine(execPath);
            }
            if (args.Length > 0)
            {
                Console.WriteLine("Received argument: " + args[0]);
            }
            else
            {
                Console.WriteLine("No argument received.");
            }
        }
    }    
}
