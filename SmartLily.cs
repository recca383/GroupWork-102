using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork_102
{
    internal class SmartLily
    {
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("Smart Lilly");

            Console.Write("\nLilly's Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPrice of the washing machine: ");
            double w = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nUnit price of each toy: ");
            int unit = Convert.ToInt32(Console.ReadLine());

            double savings = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += 10 * i / 2;
                    savings -= 1;
                }
                else
                { savings += unit / 10; }
            }

            int toys = age / 2 + age % 2;
            double toySold = toys * unit;
            savings += toySold;
            double remaining = savings - w;

            Console.WriteLine($"{toys},{savings},{unit},{age},{toySold}");
            if (remaining >= 0)
            {
                Console.WriteLine($"\nYes! {remaining:F2}");
            }
            else
            {
                Console.WriteLine($"\nNo! {Math.Abs(remaining):F2}");
            }

            Console.ReadKey(true);
            Run.MainMenu();
        }
    }
}
