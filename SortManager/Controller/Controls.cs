using Model;

namespace Controller;

public class ControllerToModel
{
    private static int _arraySize;
    private static int[] _inputArray;
    private static ISort _sortAlgorithm;

    public static string[] listOfAlgos = new string[]
    {
        "Bubble", "Merge", "Net"
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
        GenerateIntegerList(_arraySize);

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
        Random random = new Random(); //seed value based on sys clock
        
        for (int i = 0; i < n; i++)
        {
            _inputArray[i] = random.Next();
        }
    }  
}