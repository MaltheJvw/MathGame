namespace MathGame.Services
{
    public class CalculationService
    {
        // Check if the input value is correct based on the target value and the random number
        public Task<bool> IsMathCorrect(int randomNumber, int targetValue, int userInput)
        {
            // Calculate the expected value based on the random number
            int expectedValue = targetValue;

            // Check if the user input matches the expected value
            return Task.FromResult(userInput == expectedValue);
        }
    }
}
