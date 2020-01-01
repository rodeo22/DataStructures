using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Program
    {
        static char[] inputArray = { 'c', 'z', 'a', 'A'};
       // static int[] tempArray = inputArray;
        static void Main(string[] args)
        {
            SortedArray(inputArray);
        }
        static T[] SortedArray<T>(T[] inputArray) where T : IComparable
        {
            
            for (int i = 0; i < inputArray.Length; i++)
            {
                int minIndex = i;
                T minValue = inputArray[i];
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j].CompareTo(minValue) < 0 )
                    {
                        minIndex = j;
                        minValue = inputArray[j];
                    }
                }
                Swap(inputArray,i, minIndex);
            }
            return null;
        }
        static void Swap<T>(T[] inputArray,int indexOne, int indexTwo)
        {
            T temp = inputArray[indexOne];
            inputArray[indexOne] = inputArray[indexTwo];
            inputArray[indexTwo] = temp;
        }
    }
}
