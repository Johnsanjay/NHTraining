using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("F:\\C# file\\Sanjay.txt", "F:\\C# 2nd Server\\Sanjay.txt");

            Console.WriteLine("File Transfred");

            Console.ReadLine();
        }
    }
}
