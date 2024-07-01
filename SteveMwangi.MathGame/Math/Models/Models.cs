namespace Math.Models
{
    internal class Model
    {
        public int Score { get; set; }

        public GameType GameType { get; set; }

        public DateTime Date { get; set; }

        public int Questions { get; set; }

        public TimeSpan TimeTaken { get; set; }

        public Level Level { get; set; }

    }
    internal enum GameType
    {
        Addition,
        Multiplication,
        Subtraction,
        Division
    }

    internal enum Level
    {
        Easy,
        Medium,
        Hard
    }
}
