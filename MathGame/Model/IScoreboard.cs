namespace MathGame.Model
{
    public interface IScoreboard
    {
        int ScoreboardId { get; set; }

        int? Score { get; set; }

        int ProfileId { get; set; }

        Profile? Profile { get; set; }
    }
}
