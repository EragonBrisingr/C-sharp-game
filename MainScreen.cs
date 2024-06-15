using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class MainScreen
    {

        public static void Main()
        {

            Console.WriteLine("Hello world!");
            //project:
            //wordle
            //game mechanics: choose a word length then "generate" word. let user try different words. mark green letters in correct place, mark yellow 
            //correct letters but incorrect placement. Number of attempts = number of letters+1.

            //step 1: create a group of words with different letters.
            //step 2: create main game loop.
            //step 2.1: let user choose number of letters. if incorrect repeat the question.
            //step 2.2: 

            WordGenerator generate = new WordGenerator();

            
            int letters;
            string word;

            while (true)
            {
                Console.WriteLine("Enter the number of letters: ");
                //try catch in case user inputs anything other than a digit
                try
                {
                    letters = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
                break;
            }

            GameLogic game = new GameLogic();

            switch (letters)
            {
                case 3:
                    word = generate.ThreeLetters();
                    game.gameFunction(letters, word);
                    break;
                case 4:
                    word = generate.FourLetters();
                    game.gameFunction(letters, word);
                    break;
            }

            

            

            
        }

        

    }
}
