using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********   Author : K. Sanjay ***********/
/**********   Purpose : Checking prime or not using break   ********/


namespace Day_14_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 21, i;

            for (i = 2;i<n;i++)
            {
                if (n % i == 0)
                    break;
            }

            if(i==n)
                Console.WriteLine( " It is a Prime");
            else
                Console.WriteLine("It is not a prime");

            Console.ReadLine();


        }
    }
}
