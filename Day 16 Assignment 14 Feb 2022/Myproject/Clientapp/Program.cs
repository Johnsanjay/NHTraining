using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sanjaylibrary;
using Publiclibrary;

namespace Clientapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Factorial(4));
            Console.WriteLine(Physics.FinalVelocity(2,3,4));

            

            Console.ReadLine();
        }
    }
}
