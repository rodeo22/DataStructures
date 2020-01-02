using System;

namespace PracticeApp
{
    class BubbleSort
    {
        static int iterationCount = 0;

        public static void SortedArrayByBubbleSort<T>(T[] inputArray) where T : IComparable
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isThereAnyChange = false;
                iterationCount++;
                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    iterationCount++;
                    if (inputArray[j].CompareTo(inputArray[j + 1]) > 0)
                    {
                        isThereAnyChange = true;
                        Program.Swap(inputArray, j, j + 1);
                    }
                }
                if (!isThereAnyChange)
                    break;
            }
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Number Of iterations are {iterationCount}.");
        }
    }
}
