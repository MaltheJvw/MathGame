using MathGame.Data;
using Microsoft.EntityFrameworkCore;
using MathGame.Model;

namespace MathGame.Services
{
    public class UserService
    {
        private readonly AppDbContext _dbContext;

        // Static property to simulate login state
        public static bool IsLoggedIn { get; private set; } = false;

        // Event to notify when the login state changes
        public event Action OnLoginStateChanged;
        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<(UserModel? User, int? ProfileId)> LoginAsync(string username, string password)
        {
            var user = await _dbContext.Users
                .Include(u => u.Profile)
                .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                // User not found or password incorrect
                return (null, null);
            }

            IsLoggedIn = true; // Set login state
            OnLoginStateChanged?.Invoke();

            // Map User entity to UserModel for use in the app
            var userModel = new UserModel
            {
                UserId = user.UserId,
                Username = user.Username,
                Profile = user.Profile,
            };

            return (userModel, user.Profile?.ProfileId);
        }

        public async Task RegisterAsync(string username, string password)
        {
            // Check if the username already exists
            var existingUser = await _dbContext.Users
                .FirstOrDefaultAsync(u => u.Username == username);

            if (existingUser != null)
            {
                throw new InvalidOperationException("Username already exists.");
            }

            // Create a new user
            var newUser = new User
            {
                Username = username,
                Password = password,
                Profile = new Profile()
            };

            _dbContext.Users.Add(newUser);
            await _dbContext.SaveChangesAsync();
        }

        public async Task LogoutAsync()
        {
            IsLoggedIn = false;
            OnLoginStateChanged?.Invoke(); // Notify about login state change
        }
    }
}
