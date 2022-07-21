using Model;

namespace Controller;

public class ControllerToModel
{
    private static int _arraySize;
    private static int[] _inputArray;
    private static ISort _sortAlgorithm;

    string[] listOfAlgos = new string[]
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

    public static string SortArray(string sortType)
    {
        GenerateIntegerList(_arraySize);

        if (listOfAlgos.Contains(sortType))
        {

        }

        ISort sortingAlgorithm = new ISort(sortType);

        int[] sortedArray = sortingAlgorithm.Sort(inputArray);



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