using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_project_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("F:\\C# file\\method 1.txt");
            // File.WriteAllText("F:\\C# file\\method 1.txt", "Welcome to C#");
            // Console.WriteLine(File.GetCreationTimeUtc("F:\\C# file\\method 1.txt"));
            Console.WriteLine(File.GetCreationTimeUtc("F:\\C# 2nd Server\\john.txt"));
            Console.WriteLine(" File  ");
            Console.ReadLine();
        }
    }
}
