using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class SumOfAllDigit
    {
        public int sumOfElements(int[] arr)
        {
            int sum = 0;

            foreach (int num in arr)
            {
                sum += num; 
            }

            return sum;
        }
    }
}