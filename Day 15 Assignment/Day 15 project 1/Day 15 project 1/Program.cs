using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Day_15_project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy(" F:\\C# file\\Sanjay.txt", " F:\\C# 2nd Server\\Sanjay");

            Console.WriteLine("File Transfered");
            
            Console.ReadLine();

        }
    }
}
