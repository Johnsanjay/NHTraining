using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("F:\\C# 2nd Server\\john.txt",true);
            sw.WriteLine("Welcome");
            sw.WriteLine("to");
            sw.WriteLine("C# Training");
            sw.Close();

            Console.WriteLine(" File Created");

            Console.ReadLine();
        }
    }
}
