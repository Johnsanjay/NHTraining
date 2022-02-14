using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_5
{ 
    class Palindrome
    {
        int n, r, sum = 0, temp;

        public void ReadData()
        {
            Console.WriteLine("Enter Number");
            n = Convert.ToInt32(Console.ReadLine());
        }

        public void palindrome()
        {
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if(temp==sum)
                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not a Palindrome Number");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Palindrome pdr = new Palindrome();
            pdr.ReadData();
            pdr.palindrome();

            Console.ReadLine();

        }
    }
}
