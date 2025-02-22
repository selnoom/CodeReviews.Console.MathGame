using System;

namespace MathGameConsole;

internal class Menu
{
    internal void ShowMenu(string userName)
    {
        string userChoice;
        bool gameOn = true;
        int rounds = 3;

        GameEngine gameEngine = new GameEngine();

        Console.WriteLine($"Hello {userName}! Today is {DateTime.UtcNow}. Would you like to play?");

        do
        {
            Console.WriteLine("Select an option below.\n");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(
                "A - Addition\n" +
                "S - Subtraction\n" +
                "M - Multiplication\n" +
                "D - Division\n" +
                "C - Choose difficulty\n" +
                "H - View game history\n" +
                "Q - Quit the game\n");
            Console.WriteLine("-----------------------------");

            userChoice = Helper.GetNonEmptyString();
            Console.Clear();

            switch (userChoice.ToLower())
            {
                case "a":
                    gameEngine.PlayGame(Operation.Addition, rounds);
                    break;
                case "s":
                    gameEngine.PlayGame(Operation.Subtraction, rounds);
                    break;
                case "m":
                    gameEngine.PlayGame(Operation.Multiplication, rounds);
                    break;
                case "d":
                    gameEngine.PlayGame(Operation.Division, rounds);
                    break;
                case "c":
                    rounds = Helper.GetRounds();
                    break;
                case "h":
                    Helper.ShowGameHistory();
                    break;
                case "q":
                    gameOn = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please try again");
                    break;
            }
        } while (gameOn == true);
    }
}
