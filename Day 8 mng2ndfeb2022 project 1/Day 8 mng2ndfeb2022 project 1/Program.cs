using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project3
{
    class Course
    {
        public int id;
        public string name;
        public int price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> course = new List<Course>()
            {
                new Course(){ id = 1, name ="Animation",price=2000},
                new Course(){ id = 2, name ="Photoshop",price =3000},
                new Course(){ id = 3, name ="Python", price =1000},
                new Course(){ id = 4, name ="Data science", price=2900},
                new Course(){ id = 5, name ="SAP",price=(6300)}
            };

            // using for loop
            for (int i = 0; i < course.Count; i++)

            {
                Console.WriteLine($"id={course[i].id},name={course[i].name}, price={course[i].price}");
            }

            // using foreach
            foreach (var c in course)
            {
                Console.WriteLine($"id ={c.id}, name={c.name}, price={c.price}");
            }

            // using lambda 
            course.ToList().ForEach(c => Console.WriteLine($"id{c.id}, name={c.name}, price={c.price}"));



            // using LINQ 
            var result = from c in course
                         select c;
            result.ToList().ForEach(c => Console.WriteLine($"id{c.id},name={c.name},price={c.price}"));

            Console.ReadLine();
        }

    }
}