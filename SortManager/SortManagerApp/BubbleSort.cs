using System;
namespace Model;


public class BubbleSort : ISort
{
    public int[] Sort(int[] ints)
    {
        bool sorted = false;
        int[] result = new int[ints.Length];
        for (int i = 0; i < ints.Length; i++)
        {
            result[i] = ints[i];
        }

        while (!sorted)
        {
            // Switch if next element is lower
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] > result[i + 1])
                {
                    int swap = result[i];
                    result[i] = result[i + 1];
                    result[i + 1] = swap;
                }
            }

            // Check if list is sorted
            sorted = true;
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] > result[i + 1])
                    sorted = false;
            }
        }

        return result;
    }
}