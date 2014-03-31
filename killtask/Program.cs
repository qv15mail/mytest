using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace killtask
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            //Console.WriteLine(path);
            ProcessCE.FindAndKill(path + "NAND\\smartsign.exe");
            ProcessCE.FindAndKill(path + "NAND\\launch.exe");
        }
    }
}
