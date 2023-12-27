using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork_102
{
    internal class Butterfly
    {
        public static void Start()
        {
            Console.Clear();
            Console.Write("Input a number: ");
            int n = Convert.ToInt32(Console.ReadLine());


            string upperStar = "";
            string upperMinus = "";
            string head = "";
            string lowerStar = "";
            string lowerMinus = "";

            // UPPER WING STAR
            for (int i = 1; i <= (n - 2); i++)
            {
                upperStar += "*";
            }
            upperStar += "\\ /";
            for (int i = 1; i <= (n - 2); i++)
            {
                upperStar += "*";
            }

            // UPPER WING MINUS
            for (int i = 1; i <= (n - 2); i++)
            {
                upperMinus += "-";
            }
            upperMinus += "\\ /";
            for (int i = 1; i <= (n - 2); i++)
            {
                upperMinus += "-";
            }

            // BUTTERFLY HEAD
            for (int i = 1; i <= (n - 2); i++)
            {
                head += " ";
            }
            head += " @ ";

            // LOWER WING STAR
            for (int i = 1; i <= (n - 2); i++)
            {
                lowerStar += "*";
            }
            lowerStar += "/ \\";
            for (int i = 1; i <= (n - 2); i++)
            {
                lowerStar += "*";
            }

            // LOWER WING STAR
            for (int i = 1; i <= (n - 2); i++)
            {
                lowerMinus += "-";
            }
            lowerMinus += "/ \\";
            for (int i = 1; i <= (n - 2); i++)
            {
                lowerMinus += "-";
            }

            // EXECUTION
            if ((3 <= n) && (n <= 1000))
            {
                for (int rowUpper = 1; rowUpper <= (n - 2); rowUpper++)
                {
                    if (rowUpper % 2 != 0)
                    {
                        Console.WriteLine(upperStar);
                    }
                    else
                    {
                        Console.WriteLine(upperMinus);
                    }
                }

                Console.WriteLine(head);

                for (int rowLower = 1; rowLower <= (n - 2); rowLower++)
                {
                    if (rowLower % 2 != 0)
                    {
                        Console.WriteLine(lowerStar);
                    }
                    else
                    {
                        Console.WriteLine(lowerMinus);
                    }
                }
            }

            Console.ReadKey(true);
            Run.MainMenu();
        }
    }
}
