using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_mng_26jan2022_project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char inputCharacter;

            Console.WriteLine("Enter any Character");
            inputCharacter = Convert.ToChar(Console.ReadLine());

            switch (inputCharacter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Given character is a vowel");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

        }
    }
}
