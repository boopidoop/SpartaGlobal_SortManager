namespace SortingAlgorithmTests;

public class Tests
{
    MergeSort mergeSort;
    [OneTimeSetUp]
    public void Setup()
    {
        mergeSort = new MergeSort();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.PositiveInts))]
    public void Given_AnUnsortedArrayOfPositiveInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(mergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.NegativeInts))]
    public void Given_AnUnsortedArrayOfNegativeInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(mergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.PositiveAndNegativeInts))]
    public void Given_AnUnsortedArrayOfPositiveAndNegativeInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(mergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.ReversedInts))]
    public void Given_AReversedSortedArrayOfInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(mergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.SingleLengthArray))]
    public void Given_ASingleLengthArray_MergeSort_ReturnsTheSameArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(mergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.SameInts))]
    public void Given_AnArrayOfTheSameInts_MergeSort_ReturnsTheSameArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(mergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.ExtremeInts))]
    public void Given_AnArrayWithMaxValueAndMinValueInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(mergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }
}