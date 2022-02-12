using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader str = new StreamReader("F:\\C# 2nd Server\\john.txt");

            String data = str.ReadLine();

            while(data!= null)
            {
                Console.WriteLine(data);
                data = str.ReadLine();
            }

            Console.WriteLine("\n\n File Reading done");

            Console.ReadLine();
        }
    }
}
