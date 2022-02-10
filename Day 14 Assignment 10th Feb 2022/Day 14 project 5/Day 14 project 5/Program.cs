using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********   Author : K. Sanjay ***********/
/**********   Purpose : Example program using Normal Properties   ********/


namespace Day_14_project_5
{
    class Employee
    {
        private int id;
        private string name;
        private int salary;

        public int Id
        {
            get { return id; }
            set { id = 1111; }
        }
        public string Name
        {
            get { return name; }
            set { name = "John"; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = 50000; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 111;
            emp.Name = " John";
            emp.Salary = 50000;

            Console.WriteLine(emp.Id);
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Salary);

            Console.ReadLine();
        }
    }
}
