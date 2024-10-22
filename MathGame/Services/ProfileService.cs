using MathGame.Data;
using MathGame.Model;
using Microsoft.EntityFrameworkCore;

namespace MathGame.Services
{
    public class ProfileService
    {
        private readonly AppDbContext _dbContext;

        public ProfileModel? UserProfile { get; private set; }

        public ProfileService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Load current user's profile
        public async Task<ProfileModel?> LoadUserProfileAsync(int userId)
        {
            var profile = await _dbContext.Profiles
                .Include(p => p.User)  // Include User to access Username
                .FirstOrDefaultAsync(p => p.UserId == userId);

            if (profile == null) return null;

            UserProfile = new ProfileModel
            {
                ProfileId = profile.ProfileId,
                UserId = profile.UserId,
            };

            return UserProfile;
        }
    }
}
