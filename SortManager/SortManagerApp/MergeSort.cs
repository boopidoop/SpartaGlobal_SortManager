namespace Model;

public class SortingAlgorithms
{
    public static int[] MergeSort(int[] inputArr)
    {
        if (inputArr.Length <= 1) return inputArr;

        int arrSz = inputArr.Length / 2;

        int[] firstArr = new int[arrSz];                        
        int[] secondArr = new int[inputArr.Length - arrSz];     

        Array.Copy(inputArr, firstArr, arrSz);
        Array.Copy(inputArr, arrSz, secondArr, 0, secondArr.Length);

        int[] firstSorted = MergeSort(firstArr);
        int[] secondSorted = MergeSort(secondArr);

        return Merge(firstSorted, secondSorted);
    }

    public static int[] Merge(int[] first, int[] second)
    {
        int[] sorted = new int[first.Length + second.Length];

        int i = 0, j = 0, k = 0;

        // While both sorted arrays have elements that haven't been processed yet...
        while (j < first.Length && k < second.Length) 
        {
            /* Compare the current elements from both arrays.
             * Set sorted to the lowest of the two values first[j] and second[k]
             * and increment the sorted array index AND the lowest value index */
            if (first[j] <= second[k])
            {
                sorted[i++] = first[j++];
            }
            else if (first[j] > second[k])
            {
                sorted[i++] = second[k++];
            }
        }

        // By now, we have run out of elements from one of the arrays. So just copy the values from the
        // remaining array into the sorted array (because both first and second arrays are...*sorted*)
        while (j < first.Length)
        {
            sorted[i++] = first[j++];
        }

        while (k < second.Length)
        {
            sorted[i++] = second[k++];
        }

        return sorted;
    }
}