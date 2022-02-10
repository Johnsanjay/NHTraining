using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**********   Author : K. Sanjay ***********/
/**********   Purpose : Using Sealed class   ********/


namespace Day_14_project_1
{
    sealed class Manager
    {
        public static int Emergencynumber = 108;
        public string Getsecret()
        {
            return "1234JD";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { Manager mng = new Manager();
            Console.WriteLine(mng.Getsecret());

            Console.ReadLine(); 
        }
    }
}
