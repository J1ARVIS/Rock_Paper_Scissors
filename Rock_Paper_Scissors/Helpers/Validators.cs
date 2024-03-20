namespace Rock_Paper_Scissors.helpers
{
    internal class Validators
    {
        internal static bool ValidateStringLimit(string input, int limitLength)
        {
            if (string.IsNullOrEmpty(input) || input.Length > limitLength)
            {
                Console.WriteLine($"Error: String must be between 1 and {limitLength} characters long.");
                return false;
            }
            return true;
        }

        internal static bool ValidateNumLimits(int num, int bottomLimit, int topLimit)
        {
            if (num < bottomLimit || num > topLimit)
            {
                Console.WriteLine($"Error: Number must be between {bottomLimit} and {topLimit}.");
                return false;
            }
            return true;
        }

        internal static double GetValidNum(string prompt)
        {
            double number = 0;
            bool validInput = false;

            while(!validInput)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if(double.TryParse(input, out number))
                {
                    validInput = true;
                }else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            return number;
        }
    }
}
