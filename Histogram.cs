using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork_102
{
    internal class Histogram
    {
        public static void Start()
        {
            Console.Clear();
            bool run = false;
            List<int> All_Inputs = new List<int>();
            List<float> p1 = new List<float>();
            List<float> p2 = new List<float>();
            List<float> p3 = new List<float>();
            List<float> p4 = new List<float>();
            List<float> p5 = new List<float>();
            do
            {
                int input = 0;

                try
                {
                    Console.Write("Input an integer: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    All_Inputs.Add(input);

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Enter integer only ");

                }
                Console.Write("Add more numbers? (Y/N) : ");
                char response = Convert.ToChar(Console.ReadLine().ToUpper());

                run = (response == 'Y') ? true : false;


            } while (run);

            All_Inputs.ToArray();
            foreach (int i in All_Inputs)
            {
                if (i >= 800) p5.Add(i);
                else if (i >= 600) p4.Add(i);
                else if (i >= 400) p3.Add(i);
                else if (i >= 200) p2.Add(i);
                else if (i < 200) p1.Add(i);
            }
            Console.WriteLine("\nResults:  ");
            Console.WriteLine("0 - 199 = {0}%", HistogramPercentage(p1.Count, All_Inputs.Count));
            Console.WriteLine("200 - 399 = {0}%", HistogramPercentage(p2.Count, All_Inputs.Count));
            Console.WriteLine("400 - 599 = {0}%", HistogramPercentage(p3.Count, All_Inputs.Count));
            Console.WriteLine("600 - 799 = {0}%", HistogramPercentage(p4.Count, All_Inputs.Count));
            Console.WriteLine("800 above = {0}%", HistogramPercentage(p5.Count, All_Inputs.Count));

            Console.ReadKey(true);
            Run.MainMenu();
        }
        static float HistogramPercentage(float count, float total)
        {
            return (count / total) * 100;
        }
    }
}
