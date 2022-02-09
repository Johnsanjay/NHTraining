using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********   Author : K. Sanjay ***********/
/**********   Purpose : Two dimensional array and print using nested for loop   ********/

namespace Day_13_Assignment_9th_feb_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] {};
           

            for(int i = 0; i<2; i++)
            {
                for (int j = 0; j<2; j++)
                {
                    Console.Write(data[i, j] + "  ");
                    
                }
                Console.Write("\n");
            }


            Console.ReadLine();
        }
    }
}
