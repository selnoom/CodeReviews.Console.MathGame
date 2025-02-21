namespace MathGameConsole;

internal static class Helper
{
    internal static string GetNonEmptyString()
    {
        string name;
        name = Console.ReadLine();
        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Invalid name. Please try again.");
            name = Console.ReadLine();
        }
        return name;
    }

    internal static bool checkUserAnswer(int result)
    {
        int userAnswer; 
        while (!int.TryParse(Console.ReadLine(), out userAnswer))
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please try again.");
        }
        return userAnswer == result;
    }

    internal static void TypeKeyToContinue()
    {
        Console.WriteLine("Type any key to continue");
        Console.ReadLine();
        Console.Clear();
    }

    internal static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }
}