namespace MathGameConsole.Models;

class Game
{
    public DateTime Date { get; set; }
    public int Score { get; set; }
    public string Type { get; set; }
    public Difficulty Difficulty { get; set; } = Difficulty.Easy;
}
