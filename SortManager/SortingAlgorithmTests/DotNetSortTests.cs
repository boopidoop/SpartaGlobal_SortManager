using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTests;

public class DotNetSortTests
{
    [TestCaseSource(typeof(TestData), nameof(TestData.PositiveInts))]
    public void Given_AnUnsortedArrayOfPositiveInts_DotNetSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(DotNetSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.NegativeInts))]
    public void Given_AnUnsortedArrayOfNegativeInts_DotNetSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(DotNetSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.PositiveAndNegativeInts))]
    public void Given_AnUnsortedArrayOfPositiveAndNegativeInts_DotNetSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(DotNetSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.ReversedInts))]
    public void Given_AReversedSortedArrayOfInts_DotNetSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(DotNetSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.SingleLengthArray))]
    public void Given_ASingleLengthArray_DotNetSort_ReturnsTheSameArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(DotNetSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.SameInts))]
    public void Given_AnArrayOfTheSameInts_DotNetSort_ReturnsTheSameArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(DotNetSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.ExtremeInts))]
    public void Given_AnArrayWithMaxValueAndMinValueInts_DotNetSort_ReturnsSortedArray(int[] inputArray, int[] sortedArray)
    {
        Assert.That(DotNetSort.Sort(inputArray), Is.EqualTo(sortedArray));
    }
}
