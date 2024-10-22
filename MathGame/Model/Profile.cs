namespace MathGame.Model
{
    public class Profile : IProfile
    {
        public int ProfileId { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }

        public int Score { get; set; }

        public ICollection<Scoreboard>? Scoreboards { get; set; }


    }
}
