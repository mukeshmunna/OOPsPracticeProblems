using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class MaximunAndMinumumElements
    {
        public void MaximumAndMinimum(int[] arr, out int max, out int min)
        {
            max = int.MinValue; 
            min = int.MaxValue;

            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num; 
                }
            }
        }
    }
}