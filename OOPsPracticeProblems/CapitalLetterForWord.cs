using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPracticeProblems
{
    internal class CapitalLetterForWord
    {
        public string convertToTitleCase(string input)
        {
            char[] charArray = input.ToCharArray();
            int length = charArray.Length;

            if (length > 0 && char.IsLower(charArray[0]))
            {
                charArray[0] = char.ToUpper(charArray[0]);
            }

            for (int i = 1; i < length; i++)
            {
                if (charArray[i - 1] == ' ' && char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }

            return new string(charArray);
        }
    }
}

