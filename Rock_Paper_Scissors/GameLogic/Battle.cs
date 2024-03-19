using Rock_Paper_Scissors.Helpers;

namespace Rock_Paper_Scissors.GameLogic
{
    internal class Battle
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

            int randomNumber = AssistData.GenerateRandomNumber(0, prompts.Length-1);
            Console.Write($"{prompts[randomNumber]}   ('y' to start): ");

            string answer = Console.ReadLine().ToLower();
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
    }
}
