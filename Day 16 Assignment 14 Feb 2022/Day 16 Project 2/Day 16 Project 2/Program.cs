using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_2
{
    public class Mathematics
    {
        int input;

        public void ReadData()
        {
            Console.WriteLine("Enter Number");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public int GetFactorial()
        {
            int fact = 1;
            for (int i = 1; i <=input; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadData();
            Console.WriteLine(m.GetFactorial());

            Console.ReadLine();
        }

    }
}
