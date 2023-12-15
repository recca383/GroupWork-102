internal class MainProgram
{
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            string[] Options = { "Histogram", "Smart Lily", "Back to the Past", "Hospital", "Butterfly", "Stop Number", "Exit" };
            int selectedOption = 0;         
            ConsoleKeyInfo keyInfo;

            do
            {
                Console.Clear();
                Console.WriteLine(@"
        ███████╗██╗███╗   ██╗ █████╗ ██╗     ███████╗    ██████╗ ██████╗  ██████╗      ██╗███████╗ ██████╗████████╗
        ██╔════╝██║████╗  ██║██╔══██╗██║     ██╔════╝    ██╔══██╗██╔══██╗██╔═══██╗     ██║██╔════╝██╔════╝╚══██╔══╝
        █████╗  ██║██╔██╗ ██║███████║██║     ███████╗    ██████╔╝██████╔╝██║   ██║     ██║█████╗  ██║        ██║   
        ██╔══╝  ██║██║╚██╗██║██╔══██║██║     ╚════██║    ██╔═══╝ ██╔══██╗██║   ██║██   ██║██╔══╝  ██║        ██║   
        ██║     ██║██║ ╚████║██║  ██║███████╗███████║    ██║     ██║  ██║╚██████╔╝╚█████╔╝███████╗╚██████╗   ██║   
        ╚═╝     ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚══════╝╚══════╝    ╚═╝     ╚═╝  ╚═╝ ╚═════╝  ╚════╝ ╚══════╝ ╚═════╝   ╚═╝   
");

                // Center the instruction centered at the top

                string instruction = "Use arrow keys to navigate. Press Enter to select.";
                int windowWidth = Console.WindowWidth;
                int instructionPadding = (windowWidth - instruction.Length) / 2;
                Console.WriteLine(instruction.PadLeft(instructionPadding + instruction.Length));
                Console.WriteLine("");               

                for (int i = 0; i < Options.Length; i++)
                {
                    string currentOption = Options[i];
                    // Calculate padding for center alignment
                    int padding = (windowWidth - currentOption.Length) / 2;
                    // Center the options
                    string option = currentOption.PadLeft(padding + currentOption.Length);

                    if (i == selectedOption)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"{option}");
                    }
                    else
                    {                      
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{option}");
                    }
                }
                Console.ResetColor();

                // Console.Beep();

                keyInfo = Console.ReadKey(true);

                // Update selectedOption based on arrow keys

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    selectedOption--;
                    if (selectedOption == -1)
                    {
                        selectedOption = Options.Length - 1;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    selectedOption++;
                    if (selectedOption == Options.Length)
                    {
                        selectedOption = 0;
                    }
                }

            } while (keyInfo.Key != ConsoleKey.Enter);

            switch (selectedOption)
            {
                case 0:
                    Console.CursorVisible = true;
                    Histogram();
                    break;
                case 1:
                    Console.CursorVisible = true;
                    SmartLily();
                    break;
                case 2:
                    Console.CursorVisible = true;
                    BackToThePast();
                    break;
                case 3:
                    Console.CursorVisible = true;
                    Hospital();
                    break;
                case 4:
                    Console.CursorVisible = true;
                    Butterfly();
                    break;
                case 5:
                    Console.CursorVisible = true;
                    StopNumber();
                    break;
                case 6:
                    Console.CursorVisible = true;
                    ExitGame();
                    break;
            }
        }
        static void Histogram()
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
            Console.WriteLine("0 - 199 = {0}%", HistogramPercentage(p1.Count, All_Inputs.Count));
            Console.WriteLine("200 - 399 = {0}%", HistogramPercentage(p2.Count, All_Inputs.Count));
            Console.WriteLine("400 - 599 = {0}%", HistogramPercentage(p3.Count, All_Inputs.Count));
            Console.WriteLine("600 - 799 = {0}%", HistogramPercentage(p4.Count, All_Inputs.Count));
            Console.WriteLine("800 above = {0}%", HistogramPercentage(p5.Count, All_Inputs.Count));

            Console.ReadKey(true);
            MainMenu();
        }
        static float HistogramPercentage(float count, float total)
        {
            return (count / total) * 100;
        }
        static void SmartLily()
        {
            Console.Clear();
            Console.ReadKey(true);
            MainMenu();
        }

        static void BackToThePast()
        {
            Console.Clear();
            Console.ReadKey(true);
            MainMenu();
        }

        static void Hospital()
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
            MainMenu();
        }

        static void Butterfly()
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
            MainMenu();
        }

        static void StopNumber()
        {           
            Console.Clear();
            Console.ReadKey(true);
            MainMenu();
        }

        static void ExitGame()
        {         
            Console.ReadKey(true);
        }
}
