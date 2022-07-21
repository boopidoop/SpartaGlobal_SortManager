using Model;

namespace Controller;

public class ControllerToModel
{

    public static string Result(string unsortedString)
    {
        List<int> unsortedList= UnSortedStringToUnSortedList(unsortedString);
        int[] unsortedArray = UnSortedListToUnSortedArray(unsortedList);
        int[] sortedArray = GenerateSortedArray(unsortedArray);
        string sortedString = SortedStringOutput(sortedArray);
        return sortedString;
    }
    public static string SortedStringOutput(int[] sortedArray)
    {
        string sortedString = "";
        foreach (int ch in sortedArray)
            sortedString += ch;
        return sortedString;
    }

    public static int[] GenerateSortedArray(int[] unsortedArray)
    {
        int[] sortedArray = SortingAlgorithms.MergeSort(unsortedArray);
        return sortedArray;
    }
    
        
    public static List<int> UnSortedStringToUnSortedList(string inputNumbers)
    {
        var numList = new List<int>();

        foreach (char ch in inputNumbers)
        {
            if (Int32.TryParse(ch.ToString(), out int value))
                numList.Add(value);
        }
        return numList;
    }
    
    public static int[] UnSortedListToUnSortedArray(List<int> unsortedList)
    {
        int[] unsortedArray = new int[unsortedList.Count];
        for (int i = 0; i <= unsortedList.Count; i++)
            unsortedArray[i] = unsortedList[i];

        return unsortedArray;

    }


    
}