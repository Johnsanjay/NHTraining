﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Project_8
{
    internal class Program
    { 
      
    
       static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");

           int num = int.Parse(Console.ReadLine());
            int factorial = 1;
            for(int i=1;i<num;i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"Factorial of a given number is :{factorial}");

            Console.ReadLine();
        }
    }
}
