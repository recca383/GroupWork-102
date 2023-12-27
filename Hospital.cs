using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork_102
{
    internal class Hospital
    {
        public static void Start()
        {
            Console.Clear();
            Console.Write("Enter Number of Days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int doctors = 7;
            int treatedPat = 0;
            int untreatedPat = 0;

            if ((days >= 1) && (days <= 1000))
            {
                for (int period = 1; period <= days; period++)
                {
                    Console.Write("Enter Number of Patients: ");
                    int currentPat = Convert.ToInt32(Console.ReadLine());

                    if ((currentPat >= 0) && (currentPat <= 10000))
                    {
                        if ((period % 3 == 0) && (untreatedPat > treatedPat))
                        {
                            doctors++;
                        }
                        if (currentPat > doctors)
                        {
                            untreatedPat += currentPat - doctors;

                            treatedPat += doctors;
                        }
                        else
                        {
                            treatedPat += currentPat;
                        }
                    }
                    else
                    { break; }

                }

                Console.WriteLine($"Treated patients: {treatedPat}.");
                Console.WriteLine($"Untreated patients: {untreatedPat}.");
            }
            Console.ReadKey(true);
            Run.MainMenu();
        }
    }
}
