using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class GameLogic
    {


        public bool gameFunction(int letters, string word)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(word);
            Console.ResetColor();
            bool win = false;
            //first loop for number of attempts
            for (int i = 0; i < letters+1; i++)
            {
                Console.WriteLine($"You have {letters - i} attempts left!");
                Console.WriteLine("Guess the word:");
                

                string guess = Console.ReadLine();
                Console.Write("Your guess: ");

                //second loop to check characters
                for (int j = 0; j < guess.Length; j++)
                {
                    if(guess == word)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine(guess);
                        Console.ResetColor();
                        win = true;
                        return win;
                    }
                    else if (guess[j] == word[j])
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
            return win;
        }


    }
}
