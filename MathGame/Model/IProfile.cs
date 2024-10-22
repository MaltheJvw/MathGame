namespace MathGame.Model
{
    public interface IProfile
    {
        int ProfileId { get; set; }
        int UserId { get; set; }
        User? User { get; set; }


        ICollection<Scoreboard>? Scoreboards { get; set; }
    }
}
