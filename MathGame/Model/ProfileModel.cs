namespace MathGame.Model
{
    public class ProfileModel
    {
        public int ProfileId { get; set; }
        public int UserId { get; set; }
        public ICollection<Scoreboard>? Scoreboards { get; set; }

    }
}
