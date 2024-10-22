namespace MathGame.Model
{
    public interface IUser
    {

        int UserId { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        Profile Profile { get; set; }
    }
}
