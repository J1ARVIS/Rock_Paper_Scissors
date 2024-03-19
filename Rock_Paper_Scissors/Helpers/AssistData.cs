namespace Rock_Paper_Scissors.Helpers
{
    internal class AssistData
    {
        internal static int GenerateRandomNumber(int bottomLimit, int topLimit)
        {
            if (bottomLimit > topLimit)
            {
                throw new ArgumentException("Invalid arguments. Bottom limit must be less than top limit.");
            }

            Random random = new();
            return random.Next(bottomLimit, topLimit + 1);
        }
    }
}
