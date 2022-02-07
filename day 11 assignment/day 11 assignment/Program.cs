using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_11_assignment
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }
    class Circle : IShape
    {
        private int radius;
        public void ReadRadius()
        {
            Console.WriteLine("Enter radius:");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return 22 * radius * radius / 7;
        }

        public int CalculatePerimeter()
        {
            return 2 * 22 * radius / 7;
        }
    }
    class Square : IShape
    {
        private int side;
        public void ReadSide()
        {
            Console.WriteLine("Enter side:");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return side * side;
        }

        public int CalculatePerimeter()
        {
            return 4 * side;
        }
    }
    class Rectangle : IShape
    {
        private int length;
        public void ReadLength()
        {
            Console.WriteLine("Enter length:");
            length = Convert.ToInt32(Console.ReadLine());
        }
        private int width;
        public void ReadWidth()
        {
            Console.WriteLine("Enter width:");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return length * width;
        }

        public int CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
    class Triangle : IShape
    {
        private int Firstside;
        public void ReadFirstside()
        {
            Console.WriteLine("Enter First side");
            Firstside = Convert.ToInt32(Console.ReadLine());
        }
        private int Secondside;
        public void ReadSecondside()
        {
            Console.WriteLine("Enter Second side");
            Secondside = Convert.ToInt32(Console.ReadLine());
        }
        private int Lastside;

        public void ReadLastside()
        {
            Console.WriteLine("Enter Last side");
            Lastside = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateArea()
        {
            float s = (Firstside + Secondside + Secondside) / 2;
            int Area = (int)Math.Sqrt((s * (s - Firstside) * (s - Secondside) * (s - Lastside)));
            return Area;
        }

        public int CalculatePerimeter()
        {
            return Firstside + Secondside + Lastside;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.ReadRadius();
            Console.WriteLine(c.CalculatePerimeter());
            Console.WriteLine(c.CalculateArea());


            Square s = new Square();
            s.ReadSide();
            Console.WriteLine(s.CalculatePerimeter());
            Console.WriteLine(s.CalculateArea());

            Rectangle r = new Rectangle();
            r.ReadLength();
            r.ReadWidth();
            Console.WriteLine(r.CalculatePerimeter());
            Console.WriteLine(r.CalculateArea());

            Triangle t = new Triangle();
            t.ReadFirstside();
            t.ReadSecondside();
            t.ReadLastside();
            Console.WriteLine(t.CalculatePerimeter());
            Console.WriteLine(t.CalculateArea());

            Console.ReadLine(); 
        }
    }
}
