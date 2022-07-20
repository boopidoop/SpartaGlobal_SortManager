using Controller;

namespace View;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SUPER SORTING MACHINE");
        Console.WriteLine("Type in numbers with spaces to separate the numbers (eg: 1 2 3 4 5)");
        string numbers =  Console.ReadLine();
        string listNumbers = ControllerToModel.StringToArray(numbers);
        Console.WriteLine(listNumbers);
    }
}