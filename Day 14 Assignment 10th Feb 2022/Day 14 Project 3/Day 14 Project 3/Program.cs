using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********   Author : K. Sanjay ***********/
/**********   Purpose : Printing numbers from 1 to 30 skip numbers divisible by 3 using continue   ********/


namespace Day_14_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            for(int i=0;i<30;i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
