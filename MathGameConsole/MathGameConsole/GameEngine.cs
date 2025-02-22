namespace MathGameConsole

{
    internal class GameEngine
    {
        internal void PlayGame(Operation operation)
        {
            string symbol = OperationSymbols.GetSymbol(operation);
            int score = 0;
            int num1;
            int num2;
            int result;
            
            Random random = new Random();

            Console.WriteLine($"Welcome to the {operation.ToString()} game!");

            for (int i = 0; i < 3; i++)
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
                if (Helper.checkUserAnswer(result))
                {
                    score += 1;
                    Console.WriteLine("Correct! Here are the next numbers.");
                }
                else
                {
                    Console.WriteLine("Incorrect :(\n Try again with the next numbers.");
                }
                Helper.TypeKeyToContinue();
            }
            Helper.AddGameToHistory(DateTime.UtcNow, score, operation.ToString());
            Console.Clear();
            Console.WriteLine($"You made a total of {score} points!\n");
            Helper.TypeKeyToContinue();
        }
    }
}
