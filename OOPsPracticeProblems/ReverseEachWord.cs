using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class ReverseEachWord
    {
        public string reverseEachword(string input)
        {
            string[] words = input.Split(' ');

            string reversedString = "";
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string reversedWord = "";

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversedWord += word[j];
                }

                reversedString += reversedWord;

                if (i < words.Length - 1)
                {
                    reversedString += " ";
                }
            }

            return reversedString;
        }
    }
}
