using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTests;

public class UserInputTests
{
    [TestCase("BubbleSort")]
    [TestCase("Bubbles")]
    [TestCase("Bubble time")]
    [TestCase("gimme a BuBBlE")]
    [Ignore("test not implemented")]
    public void GivenBubbleSortString_CheckInput_ReturnsBubbleSort(string input) 
    {
        
    }

    [TestCase("MergeSort")]
    [TestCase("Merge")]
    [TestCase("Merge please")]
    [TestCase("gimme a MeRgE")]
    [Ignore("test not implemented")]
    public void GivenMergeSortString_CheckInput_ReturnsMergeSort(string input)
    {
        
    }

    [TestCase("DotNetSort")]
    [TestCase("DotNet")]
    [TestCase("Dotnet please")]
    [TestCase("gimme a DOTnET")]
    [Ignore("test not implemented")]
    public void GivenDotNetSortString_CheckInput_ReturnsDotNetSort(string input)
    {
        
    }

    [TestCase("x")]
    [TestCase("")]
    [TestCase("gimme something")]
    [Ignore("test not implemented")]
    public void GivenInvalidString_CheckInput_ReturnsMessage(string input)
    {
        
    }
}
