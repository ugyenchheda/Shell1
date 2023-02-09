using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Shell;

namespace ChangeDir
{
    public class Program
    {
        static void Main(string[] args)
        {

            string newDir = args[0];
            string newFilePath = "\\\\wsl.localhost\\Ubuntu\\home\\ugyen\\OS\\Shell\\ChangeDir\\workingDir.txt";
            string pathAvai = File.ReadAllText(newFilePath);
            var newWrkDir = File.ReadAllText(newFilePath);

            Console.Write(newDir);
            if (pathAvai.Length == 0)
            {
                string workingDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string fullPath = Path.Combine(workingDir, newDir);


                try
                {
                    Directory.SetCurrentDirectory(fullPath);
                    string savPath = @"\\wsl.localhost\Ubuntu\home\ugyen\OS\Shell\ChangeDir\workingDir.txt";
                    File.WriteAllText(savPath, Directory.GetCurrentDirectory());
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("The specified directory does not exist. {0}", e);
                }
                // Console.WriteLine(fullPath);

            }
            else
            {

                Directory.SetCurrentDirectory(newWrkDir);
                string workingDir = Directory.GetCurrentDirectory();
                string fullPath = Path.Combine(workingDir, newDir);


                try
                {
                    Directory.SetCurrentDirectory(fullPath);
                    string savPath = @"\\wsl.localhost\Ubuntu\home\ugyen\OS\Shell\ChangeDir\workingDir.txt";
                    File.WriteAllText(savPath, Directory.GetCurrentDirectory());
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("The specified directory does not exist. {0}", e);
                }
                // Console.WriteLine(fullPath);
            }
 
        }
    }
    public class Change
    {
        public int Execute()
        {

            string newDirMain = "Hello Ugyen";
            var process = new Process
            {
                StartInfo = new ProcessStartInfo(@"\\wsl.localhost\Ubuntu\home\ugyen\OS\backup\Shell1\CurrDirec\bin\Debug\CurrDirec.exe")
                {
                    UseShellExecute = false,
                    Arguments = "Hello World"
                }
            };

            process.Start();
            process.WaitForExit();

            return 0;
        }
    }
}
