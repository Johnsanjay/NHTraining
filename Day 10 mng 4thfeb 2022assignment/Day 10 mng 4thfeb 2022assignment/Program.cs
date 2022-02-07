using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_mng_4thfeb_2022assignment
{
    class Message
    {
        public void printHi()
        {
            Console.WriteLine("HI");
        }

        public void printHello()
        {
            Console.WriteLine("Hello");
        }
        public virtual void PrintGm()
        {
            Console.WriteLine("Good Morning");
        }
    }
    class Newmessage : Message
    {
        public override void PrintGm()
        {
            Console.WriteLine("Subhodhayam");
        }
    }
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Newmessage msg =  new Newmessage();
            msg.printHi(); 
            msg.printHello();
            msg.PrintGm();  

            Console.ReadLine();

            
        }
    }
}
