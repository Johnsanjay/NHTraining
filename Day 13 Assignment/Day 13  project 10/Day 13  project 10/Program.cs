using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********   Author : K. Sanjay ***********/
/**********   Purpose :Using Queue    ********/


namespace Day_13__project_10
{
    internal class Program
    {
        static void Main(string[] args)
        { Queue<int> data = new Queue<int>();

            data.Enqueue(21);
            data.Enqueue(96);
            data.Enqueue(74);

            Console.WriteLine(data.Count);
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count);

            Console.ReadLine();

        }
    }
}
