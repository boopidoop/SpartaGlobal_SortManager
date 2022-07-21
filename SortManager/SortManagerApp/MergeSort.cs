using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model;

public class MergeSort : SortingAlgorithms
{
    public override int[] Sort(int[] input)
    {
        // Breakpoint
        if (input.Length <= 1) return input;

        // Split into two arrays
        int inputSize = input.Length / 2;
        int[] firstArr = new int[inputSize];
        int[] secondArr = new int[input.Length - inputSize];

        Array.Copy(input, firstArr, inputSize);
        Array.Copy(input, inputSize, secondArr, 0, secondArr.Length);

        // Recursively sort
        int[] firstSorted = Sort(firstArr);
        int[] secondSorted = Sort(secondArr);

        // Merge arrays
        return Merge(firstSorted, secondSorted);
    }

    public static int[] Merge(int[] first, int[] second)
    {
        int[] sorted = new int[(first.Length + second.Length)];

        int x = 0, y = 0, i = 0;

        while((x < first.Length || y < second.Length) && i < sorted.Length)
        {
            // both arrays have contents add the lowest to sorted
            if (x < first.Length && y < second.Length)
            { 
                if (first[x] <= second[y])
                    sorted[i++] = first[x++];
                else
                    sorted[i++] = second[y++];
            }
            // one array still has contents, add it to sorted
            else if (x < first.Length)
                sorted[i++] = first[x++];
            else if (y < second.Length)
                sorted[i++] = second[y++];
        }
        return sorted;
    }
}
