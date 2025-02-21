using System;

namespace MathGameConsole;

internal class Menu
{
    internal void ShowMenu(string userName)
    {
        string userChoice;
        bool gameOn = true;

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
                "H - View game history\n" +
                "Q - Quit the game\n");
            Console.WriteLine("-----------------------------");

            userChoice = Helper.GetNonEmptyString();

            switch (userChoice.ToLower())
            {
                case "a":

                    break;

                case "s":

                    break;

                case "m":

                    break;

                case "d":

                    break;

                case "h":

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
