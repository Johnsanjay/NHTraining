using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********   Author : K.Sanjay     ************/
/********   Purpose : Exception Handling  ********/

namespace Day_12_Assignment_8th_Feb_2022
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter First number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second number: ");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;
                Console.WriteLine(c);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter only 0 to 50000");
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("We cannot divide with zero");
                
            }

            catch(FormatException)
            {
                Console.WriteLine("We have to give only numbers.Please check again");
                
            }
            catch(Exception)
            {
                Console.WriteLine("Please contact Sanjay abcde@gmail.com");
            }
            finally
            {
                Console.WriteLine("\n\n\n\n\n\n Designed by SANJAY");
                Console.ReadLine();
            }

            
        }
    }
}
