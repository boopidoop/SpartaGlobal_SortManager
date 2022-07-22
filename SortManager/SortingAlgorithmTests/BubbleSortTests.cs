using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTests;

public class BubbleSortTests
{
    BubbleSort bubbleSort;

    [OneTimeSetUp]
    public void Setup()
    {
        bubbleSort = new BubbleSort();
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.PositiveInts))]
    public void Given_AnUnsortedArrayOfPositiveInts_BubbleSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(bubbleSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.NegativeInts))]
    public void Given_AnUnsortedArrayOfNegativeInts_BubbleSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(bubbleSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.PositiveAndNegativeInts))]
    public void Given_AnUnsortedArrayOfPositiveAndNegativeInts_BubbleSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(bubbleSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.ReversedInts))]
    public void Given_AReversedSortedArrayOfInts_BubbleSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(bubbleSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.SingleLengthArray))]
    public void Given_ASingleLengthArray_BubbleSort_ReturnsTheSameArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(bubbleSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.SameInts))]
    public void Given_AnArrayOfTheSameInts_BubbleSort_ReturnsTheSameArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(bubbleSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.ExtremeInts))]
    public void Given_AnArrayWithMaxValueAndMinValueInts_BubbleSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(bubbleSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }
}
