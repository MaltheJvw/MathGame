using MathGame.Data;
using MathGame.Model;
using Microsoft.EntityFrameworkCore;

namespace MathGame.Services
{
    public class ScoreboardService
    {
        private readonly AppDbContext _dbContext;

        public ScoreboardService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Load all Profiles with their associated Scoreboards
        public async Task<List<Profile>> LoadAllProfilesWithScores()
        {
            // Fetch all profiles and include their scoreboards if any
            return await _dbContext.Profiles
                .Include(p => p.Scoreboards) // Include the related scoreboards
                .ToListAsync();
        }
    }
}
