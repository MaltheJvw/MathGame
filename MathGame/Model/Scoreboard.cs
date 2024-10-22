namespace MathGame.Model
{
    public class Scoreboard : IScoreboard
    {
        public int ScoreboardId { get; set; }

        public int? Score { get; set; }

        public int ProfileId { get; set; }
        public Profile? Profile { get; set; }
    }
}
