using System;

namespace Prov_14_okt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabler
            int correct = 5;
            string guess = "";
            int guessInt = 0;
            bool success = false;
            bool play = true;
            bool NearMiss = false;

            Console.WriteLine("WELCOME TO BATTLESHIPS!");
            while (play == true)
            {
                Console.WriteLine("Enter a coordinate (1-10)");
                success = false;

                //Tvinga fram ett giltigt svar
                while (success == false)
                {
                    guess = Console.ReadLine();
                    success = int.TryParse(guess, out guessInt);
                    if (success == false)
                    {
                        Console.WriteLine("Not a number. Try again.");
                    }
                    else if (guessInt <= 0)
                    {
                        Console.WriteLine("Coordinate cannot be less than 0. Try again.");
                        success = false;
                    }
                    else if (guessInt >= 10)
                    {
                        Console.WriteLine("Coordinate cannot be greater than 10. Try again.");
                        success = false;
                    }
                }

                NearMiss = Near(guessInt, correct);
                //Resultatet av spelarens svar
                if (guessInt == correct)
                {
                    Console.WriteLine("Hit!");
                    play = false;
                }
                else if (NearMiss == true)
                {
                    Console.WriteLine("Near miss!");
                }
                else
                {
                    Console.WriteLine("Miss!");
                }
            }
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }

        //Beslutar om det var en near miss
        static bool Near(int x, int c)
        {
            if (x == c + 1 | x == c + 2 | x == c - 1 | x == c - 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
