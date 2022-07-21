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

    }
}