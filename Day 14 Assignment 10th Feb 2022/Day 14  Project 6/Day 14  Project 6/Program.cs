using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********   Author : K. Sanjay ***********/
/**********   Purpose : Example program using Auto- implemented Properties   ********/



namespace Day_14__Project_6
{ 
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1122;
            employee.Name = "John Sanjay";
            employee.Salary = 80000;

            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Salary);

            Console.ReadLine();
        }
    }
}
