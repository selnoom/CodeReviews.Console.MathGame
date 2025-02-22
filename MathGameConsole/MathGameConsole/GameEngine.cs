namespace MathGameConsole

{
    internal class GameEngine
    {
        internal void PlayGame(Operation operation, int rounds)
        {
            string symbol = OperationSymbols.GetSymbol(operation);
            Difficulty difficulty = Helper.GetDifficulty(rounds);
            int score = 0;
            int num1;
            int num2;
            int result;
            
            Random random = new Random();

            Console.WriteLine($"Welcome to the {operation.ToString()} game!");

            for (int i = 0; i < rounds; i++)
            {
                if (operation != Operation.Division)
                {
                    num1 = random.Next(0, 10);
                    num2 = random.Next(0, 10);
                    result = Helper.ChooseOperation(operation, num1, num2);
                }
                else
                {
                    int[] divisionNumbers = Helper.GetDivisionNumbers();
                    num1 = divisionNumbers[0];
                    num2 = divisionNumbers[1];
                    result = Helper.ChooseOperation(operation, num1, num2);
                }

                Console.WriteLine($"What is {num1} {symbol} {num2}?");
                if (Helper.CheckUserAnswer(result))
                {
                    score += 1;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    Console.WriteLine("Incorrect :(\n");
                }
                Helper.TypeKeyToContinue();
            }
            Helper.AddGameToHistory(DateTime.UtcNow, score, operation.ToString(), Helper.GetDifficulty(rounds));
            Console.Clear();
            Console.WriteLine($"You made a total of {score} points on {difficulty} mode!\n");
            Helper.TypeKeyToContinue();
        }
    }
}
