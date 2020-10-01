using System;

namespace CodingChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 2, 2, 2, 3, 4, 5, 6, 6, 7, 8 };
            Console.WriteLine(FirstAndLastIndices(arr, 2));
        }

        static int[] FirstAndLastIndices(int[] sortedArr, int target)
        {
            int firstIndex = 0;
            int lastIndex = 0;
            for (int i = 0; i < sortedArr.Length; i++)
            {
                if (sortedArr[i] == target)
                {
                    firstIndex = i;
                    break;
                }
            }
            for (int j = firstIndex; j < sortedArr.Length; j++)
            {
                if (sortedArr[j] != target && sortedArr[j - 1] == target)
                {
                    lastIndex = j - 1;
                    break;
                }
            }
            return new int[] { firstIndex, lastIndex };
        }
    }
}
