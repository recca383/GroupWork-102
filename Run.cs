using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupWork_102
{
    public class Run
    {
        public static void MainMenu()
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
                    Histogram.Start();
                    break;
                case 1:
                    Console.CursorVisible = true;
                    SmartLily.Start();
                    break;
                case 2:
                    Console.CursorVisible = true;
                    BackToThePast.Start();
                    break;
                case 3:
                    Console.CursorVisible = true;
                    Hospital.Start();
                    break;
                case 4:
                    Console.CursorVisible = true;
                    Butterfly.Start();
                    break;
                case 5:
                    Console.CursorVisible = true;
                    StopNumber.Start();
                    break;
                case 6:
                    Console.CursorVisible = true;
                    ExitGame();
                    break;
            }
        }
        static void ExitGame()
        {
            Console.ReadKey();
        }
    }
}
