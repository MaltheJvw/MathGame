namespace MathGame.Services
{
    public class NumberService
    {
        // This method generates a new random number asynchronously
        public Task<int> GenerateRandomNumberAsync()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 100); // Generate a random number between 1 and 100

            // Optional: Log to console for debugging
            Console.WriteLine($"New random number generated: {randomNumber}");

            return Task.FromResult(randomNumber); // Return the generated number as a completed task
        }
    }
}
