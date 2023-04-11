using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string newFilePath = "\\\\wsl.localhost\\Ubuntu\\home\\ugyen\\OS\\Shell\\ChangeDir\\workingDir.txt";
            string pathAvai = File.ReadAllText(newFilePath);
            var newWrkDir = File.ReadAllText(newFilePath);

            if (pathAvai.Length == 0)
            {
                Console.WriteLine(Directory.GetCurrentDirectory());
            }
            else
            {
                Directory.SetCurrentDirectory(newWrkDir);
            }
            string fileName = args[0];
            string workingDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            int wordCount = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        wordCount += line.Split(' ').Length;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading the file: " + ex.Message);
            }
            Console.WriteLine("Number of words in the file: " + wordCount);
            Console.ReadKey();
        }
    }
}
