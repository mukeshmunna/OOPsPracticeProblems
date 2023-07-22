using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class UniqueElements
    {
        public void UniqueElementsInArray(int[] arr)
        {
            int length = arr.Length;
            bool isDuplicate;

            Console.Write("Unique elements in the array: ");

            for (int i = 0; i < length; i++)
            {
                isDuplicate = false;

                for (int j = 0; j < length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
