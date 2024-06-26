using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crucifixion
{
    public static class WordChecker
    {
        public static List<int> wordLengths { get; } = new List<int>
        {
            9,4,7,6,4,9,4,9,6,9

            //4 3
            //6 2
            //7 1
            //9 4
        };


        public static bool CheckWord(this string word, int wordNumber)
        {
            if (word.Length == wordLengths[wordNumber - 1])
            {
                return true;
            }
            return false;
        }

        public static bool CheckWord(this string word, int wordNumber, int index, char letter)
        {
            if (word.Length == wordLengths[wordNumber - 1] && word[index]==letter)
            {
                return true;
            }
            return false;
        }
    }
}
