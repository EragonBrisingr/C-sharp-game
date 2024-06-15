using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class GameLogic
    {


        public void gameFunction(int letters, string word)
        {
            bool win = false;

            for (int i = 0; i < letters; i++)
            {
                if (win)
                {
                    break;
                }
                Console.WriteLine($"You have {letters - i} attempts left!");
                Console.WriteLine("Guess the word:");
                string guess = Console.ReadLine();

                if (guess == word)
                {
                    Console.WriteLine("You won!");
                    break;
                }
            }
            Console.WriteLine("You lost!");
        }


    }
}
