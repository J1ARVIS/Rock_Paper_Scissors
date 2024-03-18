using Rock_Paper_Scissors.helpers;

namespace Rock_Paper_Scissors.GameLogic
{
    internal class PlayerManager
    {
        internal struct Player
        {
            internal string Nickname;
            internal int Age;
        }
        public static Player InitializePlayer(string namePrompt, string agePrompt, int nameLimitLength = 24, int ageLimitBottom = 12, int ageLimitTop = 100)
        {
            string nickname = RequestNickname(namePrompt, nameLimitLength);
            int age = RequestAge(agePrompt, ageLimitBottom, ageLimitTop);
            return new Player { Nickname = nickname, Age = age };
        }

        internal static string RequestNickname(string prompt, int limitLength)
        {
            string nickname;

            do
            {
                Console.Write($"{prompt} (max {limitLength} characters): ");
                nickname = Console.ReadLine();
            } while (!Validators.ValidateNickname(nickname, limitLength));

            return nickname;
        }

        internal static int RequestAge(string prompt, int bottomLimit, int topLimit)
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
