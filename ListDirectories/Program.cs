using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            string newFilePath = "addfile url here";
            string pathAvai = File.ReadAllText(newFilePath);
            var newWrkDir = File.ReadAllText(newFilePath);

            if (pathAvai.Length == 0)
            {
                var files = Directory.GetFiles(Directory.GetCurrentDirectory());
                var directories = Directory.GetDirectories(Directory.GetCurrentDirectory());
                foreach (var dir in directories)
                {
                    Console.WriteLine(dir); //list the directories in the current directory
                }
                foreach (var file in files)
                {
                    Console.WriteLine(file); //List the files in the current direcoty
                }
            }
            else
            {
                Directory.SetCurrentDirectory(newWrkDir);
                var files = Directory.GetFiles(Directory.GetCurrentDirectory());
                var directories = Directory.GetDirectories(Directory.GetCurrentDirectory());

                foreach (var dir in directories)
                {
                    Console.WriteLine(dir); //list the directories in the current directory
                }
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}
