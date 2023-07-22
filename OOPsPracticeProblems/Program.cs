using ObjectOrientedProblems;
using OOPsPracticeProblems;
using OOPsPracticeProblems.OOPsPracticeProblems;

internal class Program
{
    private static void Main(string[] args)
    {
        int button = 11;
        switch (button)
        {
            case 1:
                DuplicateElements duplicateElement = new DuplicateElements();
                Console.WriteLine("Object Oriented problems");
                int[] arr = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 3, 9, 9 };
                int totalDuplicates = duplicateElement.DuplicateArray(arr);
                Console.WriteLine("Total number of duplicate elements: " + totalDuplicates);
                break;
            case 2:
                int[] arr1 = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 3, 9, 9 };
                UniqueElements uniqueElement = new UniqueElements();
                uniqueElement.UniqueElementsInArray(arr1);
                break;
            case 3:
                int[] arr3 = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 3, 9, 9 };
                int[] elements = new int[arr3.Length];
                int[] frequency = new int[arr3.Length];
                FrequecyOfEachElement frequecyEachElement = new FrequecyOfEachElement();
                frequecyEachElement.countFrequency(arr3, elements, frequency);
                Console.WriteLine("Frequency of each element in the array:");
                for (int i = 0; i < elements.Length; i++)
                {
                    if (elements[i] != 0)
                    {
                        Console.WriteLine(elements[i] + ": " + frequency[i]);
                    }
                }
                break;
            case 4:

                int[] arr4 = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 3, 9, 9 };
                int maxElement, minElement;
                MaximunAndMinumumElements maximunAndMinumum = new MaximunAndMinumumElements();
                maximunAndMinumum.MaximumAndMinimum(arr4, out maxElement, out minElement);

                Console.WriteLine("Maximum element in the array: " + maxElement);
                Console.WriteLine("Minimum element in the array: " + minElement);
                break;

            case 5:
                ReverseEachWord reverseEach = new ReverseEachWord();
                string inputString = "Hello World, I am C#";

                string reversedWords = reverseEach.reverseEachword(inputString);

                Console.WriteLine("Reversed words in the string: " + reversedWords);
                break;
            case 6:
                string input1 = "this is a word";
                string input2 = "Welcome to Nexus batch";
                CapitalLetterForWord capitalizeFirstLetter = new CapitalLetterForWord();
                string titleCase1 = capitalizeFirstLetter.convertToTitleCase(input1);
                string titleCase2 = capitalizeFirstLetter.convertToTitleCase(input2);

                Console.WriteLine("Input 1: " + input1);
                Console.WriteLine("Output 1: " + titleCase1);
                Console.WriteLine("Input 2: " + input2);
                Console.WriteLine("Output 2: " + titleCase2);
                break;
            case 7:
                int[] arr7 = { 7, 2, 8, 4, 1, 9, 3, 5, 6 };
                LowestNumberFromArray smallestTwoNumber = new LowestNumberFromArray();
                int lowest1, lowest2;
                smallestTwoNumber.findTwoLowestNumbersInArray(arr7, out lowest1, out lowest2);
                int sum = lowest1 + lowest2;
                Console.WriteLine("Two lowest numbers: " + lowest1 + ", " + lowest2);
                Console.WriteLine("Sum of the two lowest numbers: " + sum);
                break;
            case 8:
                ReverseTrianglePattern patternTrinangleLower = new ReverseTrianglePattern();
                patternTrinangleLower.reversetrianglepattern(8);
                break;
            case 9:
                RectanglePattern hollowSquares = new RectanglePattern();
                hollowSquares.rectaglepattern(8);
                break;
            case 10:
                int[] arr11 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                SumOfAllDigit sumOfAllDigit = new SumOfAllDigit();
                int sum11 = sumOfAllDigit.sumOfElements(arr11);

                Console.WriteLine("Sum of array elements: " + sum11);
                break;

        }



    }

}