using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class FrequecyOfEachElement
    {
        public void countFrequency(int[] arr, int[] elements, int[] frequency)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < elements.Length; j++)
                {
                    if (arr[i] == elements[j])
                    {
                        frequency[j]++;
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    for (int k = 0; k < elements.Length; k++)
                    {
                        if (elements[k] == 0)
                        {
                            elements[k] = arr[i];
                            frequency[k]++;
                            break;
                        }
                    }
                }
            }
        }

    }
}
