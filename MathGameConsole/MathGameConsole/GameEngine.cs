using System.Diagnostics;

namespace MathGameConsole

{
    internal class GameEngine
    {
        internal void PlayGame(Operation operation, int rounds, bool isRandom = false)
        {
            // 1. Prepare common stuff
            Difficulty difficulty = Helper.GetDifficulty(rounds);
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();
            int score = 0;

            // 2. Print different “welcome” text depending on isRandom
            if (isRandom)
            {
                Console.WriteLine($"Welcome to the Random game! All operations can appear!");
            }
            else
            {
                Console.WriteLine($"Welcome to the {operation} game!");
            }
            Helper.TypeKeyToContinue();

            stopwatch.Start();

            // 3. Loop for the rounds
            for (int i = 0; i < rounds; i++)
            {
                // If random, pick a random operation each iteration;
                // otherwise, use the operation passed in
                Operation chosenOp = isRandom
                    ? Helper.GetRandomOperation()
                    : operation;

                // Now everything below is the same
                string symbol = OperationSymbols.GetSymbol(chosenOp);

                int num1;
                int num2;
                if (chosenOp != Operation.Division)
                {
                    num1 = random.Next(0, 10);
                    num2 = random.Next(0, 10);
                }
                else
                {
                    // Special logic for division
                    int[] divisionNumbers = Helper.GetDivisionNumbers();
                    num1 = divisionNumbers[0];
                    num2 = divisionNumbers[1];
                }

                int result = Helper.ChooseOperation(chosenOp, num1, num2);

                Console.WriteLine($"What is {num1} {symbol} {num2}?");
                if (Helper.CheckUserAnswer(result))
                {
                    score++;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    Console.WriteLine("Incorrect :(\n");
                }

                stopwatch.Stop();
                Helper.TypeKeyToContinue();
            }

            // 4. Add to history and display final stats
            string gameName = isRandom ? "Random" : operation.ToString();
            Helper.AddGameToHistory(DateTime.UtcNow, score, gameName, difficulty, stopwatch.Elapsed.TotalSeconds);

            Console.Clear();
            Console.WriteLine($"You made a total of {score} points on {difficulty} mode and took {stopwatch.Elapsed.TotalSeconds:F2} seconds to finish!\n");
            Helper.TypeKeyToContinue();
        }
    }
}
