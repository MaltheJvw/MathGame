namespace MathGame.Data
{
    public class Box
    {
        public int TargetValue { get; set; }
        public int Value { get; set; }
        public bool IsCorrect { get; set; }
        public string MathProblem { get; set; } // New property for displaying the math problem

        public Box(int targetValue)
        {
            TargetValue = targetValue;
            Value = 0; // Default value
            IsCorrect = false; // Initial correctness status
        }
    }
}
