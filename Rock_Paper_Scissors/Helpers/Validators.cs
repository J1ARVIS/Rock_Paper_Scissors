namespace Rock_Paper_Scissors.helpers
{
    internal class Validators
    {
        internal static bool ValidateNickname(string nickname, int limitLength)
        {
            if (string.IsNullOrEmpty(nickname) || nickname.Length > limitLength)
            {
                Console.WriteLine($"Error: Nickname must be between 1 and {limitLength} characters long.");
                return false;
            }
            return true;
        }

        internal static bool ValidateAge(int age, int bottomLimit, int topLimit)
        {
            if (age < bottomLimit || age > topLimit)
            {
                Console.WriteLine($"Error: Age must be between {bottomLimit} and {topLimit}.");
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
