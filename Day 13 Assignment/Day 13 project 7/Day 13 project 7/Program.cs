using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**********   Author : K. Sanjay ***********/
/**********   Purpose :Declaring jagged array and printing values    ********/


namespace Day_13_project_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            char[][] names = new char[3][];
            names[0] = new char[] { 'j','o','h','n'};
            names[1] = new char[] { 'j', 'o', 'h', 'n','s','a','n','j','a','y' };
            names[2] = new char[] { 'j', 'o', 'h', 'n', 's', 'a', 'n', 'j', 'a', 'y','s','o','n' };

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.Write(" \n ");
            }

            Console.ReadLine();
        }
    }
}
