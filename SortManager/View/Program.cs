using Controller;

namespace View;

public class Program
{
    public static string separator = "--------------------------";
    public static void Main(string[] args)
    {
        var devs = new string[] { "Charlie", "Dan", "David", "Laba" };
        var colours = new ConsoleColor[] { ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Green, ConsoleColor.Yellow };

        Console.Beep(300, 100);
        Console.WriteLine("Welcome to the Sorting Algorithm Application!");
        Console.Beep(300, 100);
        Console.Write("Created by: ");

        for (int i = 0; i <= 3; i++)
        {
            Console.ForegroundColor = colours[i];
            foreach (char c in devs[i])
            {
                Console.Beep(500, 100);
                Console.Write(c);
            }

            Console.ResetColor();
            if (i != 3)
                Console.Write(", ");
        }
        Console.WriteLine();
        Console.WriteLine(separator);
        SelectSortingAlgorithm();
    }

    public static void SelectSortingAlgorithm()
    {
        Console.WriteLine("Please choose a Sorting Algorithm");

        bool valid = false;
        while (!valid)
        {
            string output = ControllerToModel.CheckAlgorithmInput(Console.ReadLine());
            if (output != "")
                Console.WriteLine(output);
            else
                valid = true;
        }
        SetArraySize();
    }

    public static void SetArraySize()
    {
        Console.WriteLine("Please enter the size of the array to be sorted");

        bool valid = false;
        while (!valid)
        {
            string output = ControllerToModel.SetArraySize(Console.ReadLine());
            if (output != "")
                Console.WriteLine(output);
            else
                valid = true;
        }
    }

    public static void GetUnsortedArray()
    {

    }

    public static void Restart()
    {
        Console.WriteLine("Would you like to restart?")
    }
}