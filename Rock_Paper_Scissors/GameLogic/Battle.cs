using Rock_Paper_Scissors.Helpers;

namespace Rock_Paper_Scissors.GameLogic
{
    internal class Battle
    {
        internal enum Weapon
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }
        internal static bool PlayBattleIsWon()
        {
            string[] preBattleMessages =
            {
                "Good, let's start it! We have 3 rounds ahead!",
                "The AI awaits your challenge. 3 rounds to determine the victor!",
                "Alright, let's see what you're made of! 3 rounds to victory!"
            };

            int randomNumber = AssistData.GenerateRandomNumber(0, preBattleMessages.Length - 1);
            Console.WriteLine($"\n{preBattleMessages[randomNumber]}");

            int playerWins = 0;
            int roundsPlayed = 0;

            while (roundsPlayed < 3)
            {
                Console.Write($"\n\tRound {roundsPlayed + 1}!");

                if (!PlayRoundIsWon())
                {
                    Console.WriteLine("The AI wins this round.");
                }
                else
                {
                    playerWins++;
                    Console.WriteLine("You win this round!");
                }

                roundsPlayed++;
            }

            Console.WriteLine($"\nFinal results: Player Wins - {playerWins} rounds, AI Wins - {(roundsPlayed - playerWins)} rounds.");

            if(playerWins > roundsPlayed / 2)
            {
                return true;
            }else
            {
                return false;
            }
        }
        internal static bool PlayRoundIsWon()
        {
            Weapon playerWeapon = (Weapon)BattlePrepare.RequestWeapon();
            Weapon AIWeapon = (Weapon)BattlePrepare.GetAIWeapon((int)playerWeapon);
            Console.WriteLine($"You pick the {playerWeapon}, the AI picks the {AIWeapon}.");

            return CheckPlayerWinner(playerWeapon, AIWeapon);
        }
        internal static bool CheckPlayerWinner(Weapon playerWeapon, Weapon AIWeapon)
        {
            if ((playerWeapon == Weapon.Rock && AIWeapon == Weapon.Scissors) ||
                     (playerWeapon == Weapon.Paper && AIWeapon == Weapon.Rock) ||
                     (playerWeapon == Weapon.Scissors && AIWeapon == Weapon.Paper))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static void PraisePlayer()
        {
            string[] praiseMessages =
            {
                "Congratulations! You are a true Rock-Paper-Scissors champion!",
                "Wow, impressive victory! You dominated the AI!",
                "Excellent skills! You deserve that win!",
                "Unstoppable! You crushed the AI in that battle!",
                "Victory is yours! You're a master of Rock-Paper-Scissors!"
            };

            int randomNumber = AssistData.GenerateRandomNumber(0, praiseMessages.Length - 1);
            Console.WriteLine($"\n{praiseMessages[randomNumber]}");
        }
        internal static void EncouragePlayer()
        {
            string[] encourageMessages =
            {
                "Don't worry, better luck next time! The AI can be tough.",
                "It was a close battle! Keep practicing, and you'll conquer the AI soon!",
                "Chin up! You put up a good fight. Remember, practice makes perfect.",
                "The AI might have won this time, but you'll get them next battle!",
                "Every loss is a learning experience. You'll be a Rock-Paper-Scissors master in no time!"
            };

            int randomNumber = AssistData.GenerateRandomNumber(0, encourageMessages.Length - 1);
            Console.WriteLine($"\n{encourageMessages[randomNumber]}");
        }
    }
}
