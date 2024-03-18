using Rock_Paper_Scissors.helpers;

namespace Rock_Paper_Scissors.GameLogic
{
    internal class PlayerManager
    {
        internal static string RequestNickname(string prompt, int limitLength = 24)
        {
            string nickname;

            do
            {
                Console.Write($"{prompt} (max {limitLength} characters): ");
                nickname = Console.ReadLine();
            } while (!Validators.ValidateNickname(nickname, limitLength));

            return nickname;
        }

        internal static int RequestAge(string prompt, int bottomLimit = 12, int topLimit = 100)
        {
            int age;

            do
            {
                age = (int)Validators.GetValidNum($"{prompt} (between {bottomLimit} and {topLimit}): ");

            } while (!Validators.ValidateAge(age, bottomLimit, topLimit));

            return age;
        }
    }
}
