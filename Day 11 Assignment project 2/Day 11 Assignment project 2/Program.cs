using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Assignment_project_2
{
    class Mathematics
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }

        public static int mul(int a, int b)
        {
            return a * b;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Add(10,15));
            Console.WriteLine(Mathematics.sub(100, 50));
            Console.WriteLine(Mathematics.mul(25, 2));

            Console.ReadLine();

        }
    }
}
