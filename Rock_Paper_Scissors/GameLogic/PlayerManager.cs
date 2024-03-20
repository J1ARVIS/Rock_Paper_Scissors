using Rock_Paper_Scissors.helpers;

namespace Rock_Paper_Scissors.GameLogic
{
    internal class PlayerManager
    {
        internal struct Player
        {
            internal string Nickname;
            internal int Age;
            internal int RoundsPlayed;
            internal int BattlesWon;
        }
        internal static Player InitializePlayer(string namePrompt, string agePrompt, int nameLimitLength = 24, int ageLimitBottom = 12, int ageLimitTop = 100)
        {
            string nickname = RequestNickname(namePrompt, nameLimitLength);
            int age = RequestAge(agePrompt, ageLimitBottom, ageLimitTop);
            return new Player { Nickname = nickname, Age = age, RoundsPlayed = 0, BattlesWon = 0 };
        }

        internal static string RequestNickname(string prompt, int limitLength)
        {
            string nickname;

            do
            {
                Console.Write($"{prompt} (max {limitLength} characters): ");
                nickname = Console.ReadLine();
            } while (!Validators.ValidateStringLimit(nickname, limitLength));

            return nickname;
        }

        internal static int RequestAge(string prompt, int bottomLimit, int topLimit)
        {
            int age;

            do
            {
                age = (int)Validators.GetValidNum($"{prompt} (between {bottomLimit} and {topLimit}): ");

            } while (!Validators.ValidateNumLimits(age, bottomLimit, topLimit));

            return age;
        }

        internal static void ShowPlayerInfo(Player player)
        {
            Console.WriteLine($"\n\t>> Analyzing {player.Nickname}'s statistics...");
            Console.WriteLine($"\t╔═══════════════════════╗");
            Console.WriteLine($"\t║      Player Info      ║");
            Console.WriteLine($"\t╠═══════════════════════╣");
            Console.WriteLine($"\t║ Nickname:\t{player.Nickname}");
            Console.WriteLine($"\t║ Age:\t\t{player.Age}");
            Console.WriteLine($"\t║ Rounds Played: {player.RoundsPlayed}");
            Console.WriteLine($"\t║ Battles Won:\t{player.BattlesWon}");
            Console.WriteLine($"\t╚═══════════════════════╝\n");
        }
    }
}
