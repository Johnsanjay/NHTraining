using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**********   Author : K. Sanjay ***********/
/**********   Purpose :Using Recursion   ********/


namespace Day_13_project_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Stack<int> data  = new Stack<int>();

            data.Push(25);
            data.Push(23);
            data.Push(30);

            Console.WriteLine(data.Count);
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
