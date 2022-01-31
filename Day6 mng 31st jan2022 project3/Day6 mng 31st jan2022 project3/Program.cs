using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_mng_31st_jan2022_project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();

            data.Add("John");
            data.Add("kiran");
            data.Add("Ajay");
            data.Add("Vijay");
            data.Add("jp");
            data.Add("prasad");

            //values using  for loop
            for (int i = 0; i<data.Count; i++) 

            {
                Console.WriteLine(data[i]);
            }

            //values using for foreach loop
            foreach (var d in data)

            {
                Console.WriteLine(d);
            }

            // values using Lamda Expression
            data.ForEach(p => Console.WriteLine(p));

            Console.ReadLine();
        }
    }
}
