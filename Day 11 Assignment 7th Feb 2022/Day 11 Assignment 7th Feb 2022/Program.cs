using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Assignment_7th_Feb_2022
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
            Console.WriteLine(" Enter radius:");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return 22 *radius *radius / 7;
        }

        public int CalculatePerimeter()
        {
            return 2*22 radius / 7;
        }
    }

    class Square : IShape
    {
        private int side;

        public void ReadSide()
        {
            Console.WriteLine(" Enter side:");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return side*side;
        }

        public int CalculatePerimeter()
        {
            return 4*side;
        }
    }

    class Rectangel : IShape
    {
        private int length;
        private int breadth;

        public void ReadLength()
        {
            Console.WriteLine(" Enter length:");
            length = Convert.ToInt32(Console.ReadLine());

        }

        public void ReadBreadth()
        {
            Console.WriteLine(" Enter breadth:");
            breadth = Convert.ToInt32(Console.ReadLine());

        }
        public int CalculateArea()
        {
            return length * breadth;
        }

        public int CalculatePerimeter()
        {
            return 2 * (length + breadth);
        }
    }

    private int Firstside;

    public void ReadFirstside()
    {
        Console.WriteLine("Enter Firstside");
        Firstside = Convert.ToInt32(Console.ReadLine());
    }

    private int Secondside;

    public void ReadSecondside()
    {
        Console.WriteLine("Enter secondside");
        Secondside = Convert.ToInt32(Console.ReadLine());
    }

    private int Lastside;

    public void ReadLastside()
    {
        Console.WriteLine("Enter lastside:");
        Lastside = Convert.ToInt32(Console.ReadLine());
    }

    public int CalculateArea()
    {
        float s = (Firstside + Secondside + Lastside) / 2;

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
            Console.WriteLine(s.CalculateArea());
            Console.WriteLine(s.CalculatePerimeter());

            Rectangel r = new Rectangel();
            r.ReadLength();
            r.ReadBreadth();
            Console.WriteLine(r.CalculateArea());
            Console.WriteLine(r.CalculatePerimeter());

        Triangle t = new Triangle();
        t.ReadFirstside();
        t.ReadSecondside();
        t.ReadLastside();
        Console.WriteLine(t.CalculateArea());
        Console.WriteLine(t.CalculatePerimeter());

        Console.ReadLine();
        }
    }
}
