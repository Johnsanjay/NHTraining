using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__7_mng1st_feb2022_project_1
{
    class Department
    {
        public int id;
        public string name;
        public string place;

        public void ReadDepartment()
        {
            Console.WriteLine("Enter id:");
            id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter  department name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter department place:");
            place = Console.ReadLine();
        }

        public void PrintDepartment()
        {
            Console.WriteLine($"Id={id},Name={name},Place={place}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { 
            Department department1 = new Department();
            department1.ReadDepartment();
            department1.PrintDepartment();

            Console.ReadLine();


        }
    }
}
