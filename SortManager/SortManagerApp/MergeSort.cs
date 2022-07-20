namespace Model;

public class SortingAlgorithms
{
    public static int[] MergeSort(int[] inputArr)
    {
        if (inputArr.Length <= 1) return inputArr;

        int arrSz = inputArr.Length / 2;

        int[] firstArr = new int[arrSz];                        // 1, 5, 6
        int[] secondArr = new int[inputArr.Length - arrSz];     // 2, 7

        Array.Copy(inputArr, firstArr, arrSz);
        Array.Copy(inputArr, arrSz, secondArr, 0, secondArr.Length);

        int[] firstSorted = MergeSort(firstArr);
        int[] secondSorted = MergeSort(secondArr);

        return Merge(firstSorted, secondSorted);
    }

    public static int[] Merge(int[] first, int[] second)
    {
        int[] sorted = new int[first.Length + second.Length];

        for (int i = 0, j = 0, k = 0; i < sorted.Length; i++)
        {
            if (first[j] < second[k])
            {
                sorted[i] = first[j];
                j++;
            } else if (first[j] > second[k])
            {
                sorted[i] = second[k];
                k++;
            }
            else if (first[j] == second[k])
            {

            }

        }
        return sorted;
    }
}