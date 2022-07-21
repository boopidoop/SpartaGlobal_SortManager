namespace SortingAlgorithmTests;

public class Tests
{

    [TestCaseSource(typeof(TestData), nameof(TestData.PositiveInts))]
    public void Given_AnUnsortedArrayOfPositiveInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(MergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.NegativeInts))]
    public void Given_AnUnsortedArrayOfNegativeInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(MergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.PositiveAndNegativeInts))]
    public void Given_AnUnsortedArrayOfPositiveAndNegativeInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(MergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.ReversedInts))]
    public void Given_AReversedSortedArrayOfInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(MergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.SingleLengthArray))]
    public void Given_ASingleLengthArray_MergeSort_ReturnsTheSameArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(MergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.SameInts))]
    public void Given_AnArrayOfTheSameInts_MergeSort_ReturnsTheSameArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(MergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.ExtremeInts))]
    public void Given_AnArrayWithMaxValueAndMinValueInts_MergeSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(MergeSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }
}