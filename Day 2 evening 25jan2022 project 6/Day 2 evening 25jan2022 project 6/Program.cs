using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_evening_25jan2022_project_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Console.WriteLine("Enter any Number :");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
               Console.WriteLine(input+"*"+i+"="+input*i);
            }


                for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", input, i, input * 1);
            }

            Console.ReadLine();
        }
    }
}
