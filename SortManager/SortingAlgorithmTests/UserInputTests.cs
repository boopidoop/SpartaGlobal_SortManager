using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmTests;

public class UserInputTests
{
    [TestCase("BubbleSort")]
    [TestCase("Bubble")]
    [TestCase("BuBBle")]
    public void GivenBubbleSortString_CheckInput_ReturnsBubbleSort(string input) 
    {
        
    }

    [TestCase("MergeSort")]
    [TestCase("Merge")]
    [TestCase("MerGe")]
    public void GivenMergeSortString_CheckInput_ReturnsMergeSort(string input)
    {
        
    }

    [TestCase("DotNetSort")]
    [TestCase("DotNet")]
    [TestCase("DotNET")]
    public void GivenDotNetSortString_CheckInput_ReturnsDotNetSort(string input)
    {
        
    }

    [TestCase("x")]
    [TestCase("")]
    [TestCase("gimme something")]
    public void GivenInvalidString_CheckInput_ReturnsMessage(string input)
    {
        
    }
}
