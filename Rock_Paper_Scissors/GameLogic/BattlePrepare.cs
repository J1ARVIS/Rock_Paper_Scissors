using Rock_Paper_Scissors.helpers;

namespace Rock_Paper_Scissors.GameLogic
{
    internal class BattlePrepare
    {
        internal static bool CheckReadyForBattle()
        {
            string[] prompts = {
              $"Glove up! Are you ready to throw down?",
              $"Feeling lucky? Time to test your skills!",
              $"The arena awaits! Prepare for glory!",
              $"Gear up! Battle awaits!",
              $"Time to clash! Ready to battle?"
            };

            string answer;
            do
            {
                int randomNumber = AssistData.GenerateRandomNumber(0, prompts.Length - 1);
                Console.Write($"{prompts[randomNumber]}   ('y' to start): ");
                answer = Console.ReadLine().ToLower();
            } while (!Validators.ValidateStringLimit(answer, 10));
            
            return answer == "y";
        }

        internal static void ExitGame()
        {
            string[] farewellMessages = {
              "Farewell, adventurer! May your future battles be glorious!",
              "Thanks for playing! Come back and test your skills again soon.",
              "Until next time, champion! May fortune favor you.",
              "See you later! Remember, practice makes perfect for the next fight!",
              "Take care, warrior! May your path be filled with exciting challenges.",
            };

            int randomNumber = AssistData.GenerateRandomNumber(0, farewellMessages.Length - 1);
            Console.WriteLine($"\n{farewellMessages[randomNumber]}");
        }

        internal static int RequestWeapon()
        {
            string[] weaponPrompts = {
              "Rock, paper, or scissors? Choose your weapon!",
              "Prepare for battle! Pick your weapon!",
              "Time to duel! What weapon do you wield?",
              "Show your might! Choose your weapon!",
              "Fate awaits! What will it be?",
            };

            int weaponChoice;
            do
            {
                int randomNumber = AssistData.GenerateRandomNumber(0, weaponPrompts.Length - 1);
                weaponChoice = (int)Validators.GetValidNum($"{weaponPrompts[randomNumber]}   (rock = 1, paper = 2, scissors = 3): ");

            } while (!Validators.ValidateNumLimits(weaponChoice, 1, 3));

            return weaponChoice;
        }

        internal static int GetAIWeapon()
        {

        }
    }
}
