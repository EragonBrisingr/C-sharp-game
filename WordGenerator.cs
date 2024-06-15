using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class WordGenerator
    {

        public string ThreeLetters()
        {
            //array of three letter words
            string[] words = [
                "tie",
                "bye",
                "try",
                "lie",
                "man",
                "lol",
                "pig",
                "woo",
                "two"];

            Random random = new Random();

            int index = random.Next(words.Length);

            return words[index];
        }

        public string FourLetters()
        {
            //array of three letter words
            string[] words = [
                "wolf",
                "wool",
                "aide",
                "liar",
                "bear",
                "load",
                "face",
                "hand",
                "love"];

            Random random = new Random();

            int index = random.Next(words.Length);

            return words[index];
        }

    }
}
