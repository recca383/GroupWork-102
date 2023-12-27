using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork_102
{
    internal class StopNumber
    {
        public static void Start () 
        {
            Console.Clear ();

            //Initialize
            int S , N, M;
            
            List<int> Divisible_By_Two = new List<int>();
            List<int> Divisible_By_Three = new List<int>();

            //s
            Console.WriteLine("Stop Number\n");
            Console.Write("Enter lowest number: ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter highest number: ");
            M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Stop number: ");
            S = Convert.ToInt32(Console.ReadLine());

            //Put data in the list
            for (int i = M; i >= N; i--)
            {
                if (i % 2 == 0) Divisible_By_Two.Add(i);
                if (i % 3 == 0) Divisible_By_Three.Add(i);
            }

            //Intersect 2 lists
            IEnumerable<int> Display = Divisible_By_Two.AsQueryable().Intersect(Divisible_By_Three);

            
            Console.WriteLine("Results : ");
            foreach (int i in Display)
            {
                //Check if Stop number is valid
                if (S % 2 == 0 && S % 3 == 0)
                {
                    //Remove Stop number and break the loop
                    if (i == S)
                    {
                        Divisible_By_Two.Remove(S);
                        break; 
                    }
                }
                //Display results
                Console.Write($"{i} ");
            }


            Console.ReadKey(true);
            Console.Clear();
            Run.MainMenu();
        }
        
    }
}
