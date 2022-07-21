using Model;

namespace Controller;

public class ControllerToModel
{

    public static (string, int) CheckInput(string inputSortType)
    {
        if (Int32.TryParse(inputSortType, out int sortType))
        {
            if (sortType <= 0)
            {
                //TODO - Call Error function
                return ($"Cannot have an array of size {sortType}", -999);
            }
        }
        return ("", sortType);
    }

    public void SortAlgorithm(ISort sortAlgo)
    {
        // Not yet implemented
    }
    public static int[] GenerateIntegerList(int n)
    {
        if (n <= 0) return new int[] {};

        int[] inputIntLs = new int[n];

        Random random = new Random(); //seed value based on sys clock
        
        for (int i = 0; i < n; i++)
        {
            inputIntLs[i] = random.Next();
        }
        return inputIntLs;
    }

    
}