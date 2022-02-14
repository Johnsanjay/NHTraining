using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JohnLibrary;
using System.Threading.Tasks;

namespace Day_16_Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadData();
            Console.WriteLine(m.Factorial());


            Physics p = new Physics();
            Console.WriteLine(p.FinalVelocity(8,5,2));

            Chemistry ch = new Chemistry();
            Console.WriteLine(ch.Benzene());
            Console.WriteLine(ch.Water());
            Console.WriteLine(ch.Methane());

            
            Console.ReadLine();

        }
    }
}
