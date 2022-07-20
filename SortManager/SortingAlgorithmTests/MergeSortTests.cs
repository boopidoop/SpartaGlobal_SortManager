namespace SortingAlgorithmTests;

public class Tests
{

    static object[] SortCases =
    {
        new object[] { new int[] { 3,2,1 }, new int[] { 1,2,3 } },
        new object[] { new int[] { 7,-7,100,4,1 }, new int[] { -7,1,4,7,100 } },
        new object[] { new int[] { }, new int[] { } },
        new object[] { new int[] { -8,-23,-15 }, new int[] { -23,-15,-8 } },
        new object[] { new int[] { 80,25,16 }, new int[] { 16,25,80 } }
    };


    [TestCaseSource(nameof(SortCases))]
    public void Given_AnUnsortedArray_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(SortingAlgorithms.MergeSort(inputArray), Is.EqualTo(sortedArray));
    }


    static object[] MergeCases =
    {
        new object[] { new int[] { 3,9,1 }, new int[] { 4, 2, }, new int[] { 1,2,3,4,9 } },
        new object[] { new int[] { 8,3,4 }, new int[] { 0, 7, }, new int[] { 0,3,4,7,8 } }
    };

    [TestCaseSource(nameof(MergeCases))]
    public void Given_TwoArrays_Merge_ReturnsMergedSortedArray(int[] firstHalf, int[] secondHalf, int[] mergedSortedArray) 
    {
        Assert.That(SortingAlgorithms.Merge(firstHalf, secondHalf), Is.EqualTo(mergedSortedArray));
    }

}