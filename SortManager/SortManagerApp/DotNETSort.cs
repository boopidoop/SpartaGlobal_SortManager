using System;
namespace Model;


public class DotNetSort : SortingAlgorithms
{
    public static int[] Sort(int[] ints)
    {
        List<int> sortedList = UnsortedArrayToUnsortedList(ints);
        sortedList = UnsortedListToSortedList(sortedList);
        int[] sortedArray = SortedListToSortedArray(sortedList);

        return sortedArray;
    }
    public static List<int> UnsortedArrayToUnsortedList(int[] array)
    {
        var list = new List<int>();
        foreach (int el in array)
            list.Add(el);

        return list;
    }
    public static List<int> UnsortedListToSortedList(List<int> list)
    {
        list.Sort();
        return list; 
    }
    public static int[] SortedListToSortedArray(List<int> list)
    {
        int length = list.Count;
        int[] sortedArray = new int[length];
        for (int i = 0; i < length; i++)
            sortedArray[i] = list[i];
        return sortedArray;
    }

}