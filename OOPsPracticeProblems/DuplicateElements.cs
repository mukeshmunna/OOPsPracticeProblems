﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class DuplicateElements
    {
        public int DuplicateArray(int[] arr)
        {
            int totalDuplicates = 0;
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        totalDuplicates++;
                        break; 
                    }
                }
            }

            return totalDuplicates;
        }







    }
}