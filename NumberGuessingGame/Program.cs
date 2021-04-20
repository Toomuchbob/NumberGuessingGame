using System;
using static System.Console;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(1, 101);

            bool win = false;

            //WriteLine(winNum);

            int i = 0;

            do
            {
                Write("Guess a number between 1 and 100: ");
                string s = ReadLine();

                try
                {
                    i = int.Parse(s);
                }
                catch (Exception e)
                {
                    switch (e)
                    {
                        case FormatException:
                        case OverflowException:
                        case ArgumentNullException:
                            WriteLine("Please enter a number between 1 and 100!");
                            break;
                        default:
                            WriteLine(e);
                            break;
                    }
                }

                if (i > winNum)
                {
                    WriteLine("Too high! Guess lower...");

                }
                else if (i < winNum)
                {
                    WriteLine("Too low! Guess higher...");
                }
                else if (i == winNum)
                {
                    WriteLine("You WIN!");
                    win = true;
                }
            } while (win == false);

            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
