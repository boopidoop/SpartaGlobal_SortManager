using Model;
using System.Diagnostics;

namespace Controller;

public class Controls
{
    public static int _arraySize;
    private static int[] _inputArray;
    public static ISort _sortAlgorithm;

    public static string[] listOfAlgos = new string[]
    {
        "BubbleSort", "MergeSort", ".NET Sort"
    };

    public static string CheckArrayInput(string arraySizeInput)
    {
        if (Int32.TryParse(arraySizeInput, out int arraySize))
        {
            if (arraySize <= 0)
            {
                return $"Cannot have an array of size {arraySize}";
            }
        }
        else
            return "Array size must be an integer";

        _arraySize = arraySize;

        return "";
    }

    public static string CheckAlgorithmInput(string sortType)
    {
        switch(sortType.ToLower())
        {
            case "merge":
            case "mergesort":
                _sortAlgorithm = new MergeSort();
                return "";
            case "bubble":
            case "bubblesort":
                _sortAlgorithm = new BubbleSort();
                return "";
            case "net":
            case "netsort":
                _sortAlgorithm = new DotNetSort();
                return "";
            default:
                return "Sort algorithm not recognised";
        }
    }

    public static void GenerateIntegerList(int n)
    {
        Random random = new Random();
        _inputArray = new int[_arraySize];
        
        for (int i = 0; i < n; i++)
        {
            _inputArray[i] = random.Next(0,100);
        }
    }

    public static void FirstRun()
    {
        GenerateIntegerList(_arraySize);
        _sortAlgorithm.Sort(_inputArray);
    }

    public static string Run()
    {
        FirstRun();
        //runs once to fix time bug
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        
        var sortedArray = _sortAlgorithm.Sort(_inputArray);

        stopwatch.Stop();

        return $"Results" +
            $"\n\tUnsorted: \t[{string.Join(", ", _inputArray)}]" +
            $"\n\tSorted: \t[{string.Join(", ", sortedArray)}]" +
            $"\n\tTime Taken: \t{stopwatch.ElapsedTicks} ticks";
    }
}