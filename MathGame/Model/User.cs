using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MathGame.Model
{
    public class User : IUser
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Profile Profile { get; set; }
    }
}
