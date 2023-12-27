using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork_102
{
    internal class BackToThePast
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Back to the Past!!");
            //Getting the inherited money
            Console.Write("\nInherited money: ");
            double x = Convert.ToDouble(Console.ReadLine());
            //getting the wanted year
            Console.Write("Year, until which he has to live in the past (inclusive): ");
            int year = Convert.ToInt32(Console.ReadLine());
            //loop for year
            for (int i = 1800; i <= year; i++)
            {//if the i which is the fix year is less than the wanted year it will add
             //if it is even it will deduct 12000
                if (i % 2 == 0)
                {
                    x -= 12000;
                }
                else
                //if odd it will deduct 12000+50*(age)
                {
                    x -= 12000 + 50 * (i - 1800 + 18);
                }

            }
            //if x is less than 0, it will print the needed money
            if (x < 0)
            {
                double n = Math.Abs(x);
                Console.WriteLine($"\nHe will need {n:F2} dollars to survive.");
                Console.ReadKey(true);
                Run.MainMenu();
            }
            //if not, it will print the left money
            Console.WriteLine($"\nYes! He will live a carefree life and will have {x:F2} dollars left.");

            Console.ReadKey(true);
            Run.MainMenu();
        }
    }
}
