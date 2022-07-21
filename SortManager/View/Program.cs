using Controller;

namespace View;

public class Program
{
    public static string separator = "--------------------------";
    private static ConsoleColor[] colours = new ConsoleColor[] { ConsoleColor.Blue, ConsoleColor.Magenta, ConsoleColor.Green, ConsoleColor.Yellow };
    private static Random random;

    public static void Main(string[] args)
    {
        var devs = new string[] { "Charlie", "Dan", "David", "Laba" };
        random = new Random();

        Console.Beep(300, 100);
        Console.WriteLine("Welcome to the Sorting Algorithm Application!");
        Console.Beep(300, 100);
        Console.Write("\tCreated by: ");

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
            else
                Console.WriteLine();
        }

        SelectSortingAlgorithm();
    }

    public static void SelectSortingAlgorithm()
    {
        Console.Beep(300, 100);
        Console.WriteLine(separator);
        Console.WriteLine("Please choose a Sorting Algorithm from the Following:");

        foreach (var alg in Controls.listOfAlgos)
        {
            Console.Beep(500, 100);
            Console.ForegroundColor = colours[random.Next(colours.Length)];
            Console.WriteLine(alg.ToString());
        }
        Console.ResetColor();

        bool valid = false;
        while (!valid)
        {
            Console.Beep(300, 100);
            Console.Write(" > ");
            Console.ForegroundColor = ConsoleColor.Green;
            string output = Controls.CheckAlgorithmInput(Console.ReadLine());
            Console.ResetColor();

            if (output != "")
                Console.WriteLine(output);
            else
                valid = true;
        }

        SetArraySize();
    }

    public static void SetArraySize()
    {
        Console.Beep(300, 100);
        Console.WriteLine(separator);
        Console.WriteLine("Please enter the size of the array to be sorted");

        bool valid = false;
        while (!valid)
        {
            Console.Beep(300, 100);
            Console.Write(" > ");
            Console.ForegroundColor = ConsoleColor.Green;
            string output = Controls.CheckArrayInput(Console.ReadLine());
            Console.ResetColor();

            if (output != "")
                Console.WriteLine(output);
            else
                valid = true;
        }

        Confirm();
    }

    public static void Confirm()
    {
        Console.Beep(300, 100);
        Console.WriteLine(separator);
        Console.WriteLine("Are these details correct? [Y/N]");
        Console.Beep(500, 100);
        Console.WriteLine($"\tSort Type: {Controls._sortAlgorithm}");
        Console.Beep(500, 100);
        Console.WriteLine($"\tArray Size: {Controls._arraySize}");

        bool valid = false;
        string output = "";
        while (!valid)
        {
            Console.Beep(300, 100);
            Console.Write(" > ");
            Console.ForegroundColor = ConsoleColor.Green;
            output = Console.ReadLine();
            Console.ResetColor();

            if (output.ToLower() == "y" || output.ToLower() == "n")
                valid = true;
            else
                Console.WriteLine("Please enter a valid input (Format: [Y/N])");
        }

        if (output.ToLower() == "y")
            Console.WriteLine(Controls.Run());
        if (output.ToLower() == "n")
            SelectSortingAlgorithm();

        End();
    }

    public static void End()
    {
        Console.Beep(300, 100);
        Console.WriteLine(separator);
        Console.WriteLine("Would you like to restart or quit?");

        bool valid = false;
        string output = "";
        while (!valid)
        {
            Console.Beep(300, 100);
            Console.Write(" > ");
            Console.ForegroundColor = ConsoleColor.Green;
            output = Console.ReadLine();
            Console.ResetColor();

            if (output.ToLower() == "restart" || output.ToLower() == "quit")
                valid = true;
            else
                Console.WriteLine("Please enter either 'restart' or 'quit'");
        }


        if (output.ToLower() == "restart")
            SelectSortingAlgorithm();
        else
        {
            Console.WriteLine("Thank you for using the application!");
            for (int i = 500; i > 100; i -= 100)
            {
                Console.Beep(i, 100);
            }
        }
    }
}