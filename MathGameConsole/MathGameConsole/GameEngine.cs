namespace MathGameConsole

{
    internal class GameEngine
    {
        internal void AdditionGame()
        {
            int score = 0;

            Console.WriteLine("Welcome to the addition game!");

            for (int i = 0; i < 6; i++ )
            {
                Random random = new Random();
                int num1 = random.Next(0, 10);
                int num2 = random.Next(0, 10);
                int result = Helper.Addition(num1, num2);

                Console.WriteLine($"What is the sum of {num1} and {num2}?");
                if (Helper.checkUserAnswer(result))
                {
                    score += 1;
                    Console.WriteLine("Correct! Here are the next numbers.");
                }
                else
                {
                    Console.WriteLine("Incorrect :(. Try again with the next numbers.");
                }
            }
            Console.Clear();
            Console.WriteLine($"You made a total of {score} points!\n");
            Helper.TypeKeyToContinue();
        }
    }
}
