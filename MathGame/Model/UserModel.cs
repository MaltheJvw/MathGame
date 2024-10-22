namespace MathGame.Model
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Profile Profile { get; set; } = new Profile();
    }
}
