using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            var shell = new Shell();
            shell.Run();
        }
    }

    public class Shell
    {
        private Dictionary<string, string> Aliases = new Dictionary<string, string>
        {
            { "ls", @".\ListDirectories.exe" },
            { "pwd", @".\CurrDirec.exe" },
            { "clear", @".\Clear.exe" }
        };

        public void Run()
        {
            //this is the part
            string input = null;
            do
            {
                Console.Write("$ ");
                input = Console.ReadLine();
                Execute(input);
            } while (input != "exit");
        }

        public int Execute(string input)
        {
            if (input.StartsWith("cd "))
            {
                string newDir = input.Substring(3);
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo(@".\ChangeDir.exe")
                    {
                        UseShellExecute = false,
                        Arguments = newDir
                    }
                };

                process.Start();
                process.WaitForExit();

                return 0;
            }

            if (input.StartsWith("wc "))
            {
                string fileName = input.Substring(3);
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo(@".\WordCount.exe")
                    {
                        UseShellExecute = false,
                        Arguments = fileName
                    }
                };

                process.Start();
                process.WaitForExit();

                return 0;
            }

            if (Aliases.Keys.Contains(input))
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo(Aliases[input])
                    {
                        UseShellExecute = false
                    }
                };

                process.Start();
                process.WaitForExit();

                return 0;
            }

            Console.WriteLine($"{input} not found");
            return 1;
        }
    }
}
