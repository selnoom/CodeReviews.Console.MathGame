using MathGameConsole.Models;

namespace MathGameConsole;

internal static class Helper
{
    internal static List<Game> games = new List<Game>();

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
        Console.WriteLine("\nPress enter to continue");
        Console.ReadLine();
        Console.Clear();
    }

    internal static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }

    internal static int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }

    internal static int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }

    internal static int Division(int num1, int num2)
    {
        return num1 / num2;
    }

    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(1, 99);
        var secondNumber = random.Next(1, 99);

        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        result[0] = firstNumber;
        result[1] = secondNumber;

        return result;
    }

    internal static int ChooseOperation(Operation operation, int num1, int num2)
    {
        switch (operation)
        {
            case Operation.Addition:
                return Addition(num1, num2);
            case Operation.Subtraction:
                return Subtraction(num1, num2);
            case Operation.Multiplication:
                return Multiplication(num1, num2);
            case Operation.Division:
                return Division(num1, num2);
            default:
                throw new IndexOutOfRangeException();
        }
    }

    internal static void ShowGameHistory()
    {
        if (games.Count() > 0)
        {
            Console.Clear();
            Console.WriteLine("Game History:\n");
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date}\t{game.Type}\t{game.Score}");
            }
        }
        else
        {
            Console.WriteLine("No games registered yet.");
        }
        TypeKeyToContinue();
        Console.Clear();
    }

    internal static void AddGameToHistory(DateTime time, int score, string type)
    {
        games.Add(new Game
        {
            Date = time,
            Score = score,
            Type = type
        });
    }
}