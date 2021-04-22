using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number inbeteween 0 and 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too high! Guess lower :/ ");

                }
                else if (i < winNum)
                {
                    Console.WriteLine("Guess higher :( ");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You win 0.20 E");
                    win = true;

                }
                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("Thank you for playing the game :)");
            Console.WriteLine("It took me about 1 hour to make it 0_0");
            Console.Write("Press any key to finish");
            Console.ReadKey(true);
        } 
    }
}
