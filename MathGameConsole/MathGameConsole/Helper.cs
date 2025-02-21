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
}