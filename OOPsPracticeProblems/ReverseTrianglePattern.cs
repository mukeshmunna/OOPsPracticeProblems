using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsPracticeProblems
{
    internal class ReverseTrianglePattern
    {
        public void reversetrianglepattern(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
}

