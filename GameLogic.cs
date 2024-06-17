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

            //first loop for number of attempts
            for (int i = 0; i < letters; i++)
            {
                if (win)
                {
                    break;
                }
                Console.WriteLine($"You have {letters - i} attempts left!");
                Console.WriteLine("Guess the word:");
                
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(word);
                Console.ResetColor();

                string guess = Console.ReadLine();
                
                //second loop to check characters
                for (int j = 0; j < guess.Length; j++)
                {
                    if (guess[j] == word[j])
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(guess[j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(guess[j]);
                    }
                }
                Console.WriteLine();                
            }
            Console.WriteLine("You lost!");
        }


    }
}
