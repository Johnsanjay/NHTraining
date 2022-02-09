using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********   Author : K. Sanjay ***********/
/**********   Purpose :Trace of the array   ********/


namespace Day_13_project_2_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] data = new int[,] { { 5, 9,4 }, { 6, 8,1 }, { 8,24,6} };
            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                   if(i==j)
                        sum = sum + data[i,j];

                }
                
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
