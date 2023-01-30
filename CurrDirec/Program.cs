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
                string execPath = Directory.GetCurrentDirectory();
                Console.WriteLine(execPath);
    }
    }
}
