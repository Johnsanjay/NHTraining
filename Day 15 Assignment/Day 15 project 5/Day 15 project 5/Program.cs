using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day_15_project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter swr = new StreamWriter("F:\\C# file\\Quiz score");

            int score = 0, ans;
            String name;
            Console.WriteLine("Enter your Name:");
            name = Console.ReadLine();

            Console.WriteLine("*******************************");
            Console.WriteLine("Hi {0}, Welcome to the quiz by Sanjay", name);
            Console.WriteLine("******************************");

            swr.WriteLine(name);

            Console.WriteLine("Q1.Who won the 2021 Test Championship? ");
            Console.WriteLine("1.India  2.westindies  3.New zealand   4.Srilanka");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;

            Console.ReadLine();



            Console.WriteLine("Q2.Which player Regiestred the Highest individual score in Odi's?  ");
            Console.WriteLine("1.Rohit Sharma  2.sachin  3.Galye   4.virendra sehwag");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score += 20;

            Console.ReadLine();



            Console.WriteLine("Q3.What is the largest cricket stadium in the world? ");
            Console.WriteLine("1.Lords  2.MCG  3.Eden Gardens   4.Narendra Modi Stadium");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 4)
                score += 20;

            Console.ReadLine();


            Console.WriteLine("Q4.Who is the only batsman to record 400 runs in an international Test match? ");
            Console.WriteLine("1.Don Bradman  2.Brain Lara  3.WG Grace   4.Steve smith");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;

            Console.ReadLine();


            Console.WriteLine("Q5.Which indian Cricketer did th miracle by making a century in 20 balls in a T-20 match?");
            Console.WriteLine("1.Hadrik pandya  2.Rishab pant  3.Wriddhiman saha   4.K L Rahul");
            Console.WriteLine("Enter Your Choice:");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;
                
            swr.WriteLine(score);
            swr.Close();

            Console.WriteLine("Thank you for taking the quiz admin can show your result");


            Console.ReadLine();
        }
    }
}
