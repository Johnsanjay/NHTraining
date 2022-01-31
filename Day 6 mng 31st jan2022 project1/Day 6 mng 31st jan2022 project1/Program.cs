using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_mng_31st_jan2022_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();
            int sum = 0;
            data.Add(22);
            data.Add(95);
            data.Add(65);
            data.Add(20);

            foreach( var d in data )
            {
                sum = sum  + (int)d;     
            }

            Console.WriteLine(sum);
            Console.ReadLine();
               


        }
    }
}
