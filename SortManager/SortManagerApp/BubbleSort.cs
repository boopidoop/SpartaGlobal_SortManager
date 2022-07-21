using System;
namespace Model;


public class BubbleSort : ISort
{
    public int[] Sort(int[] ints)
    {
        bool sorted = false;
        while (!sorted)
        {
            // Switch if next element is lower
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] > ints[i + 1])
                {
                    int swap = ints[i];
                    ints[i] = ints[i + 1];
                    ints[i + 1] = swap;
                }
            }

            // Check if list is sorted
            sorted = true;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] > ints[i + 1])
                    sorted = false;
            }
        }

        return ints;
    }
}