using Rock_Paper_Scissors.GameLogic;

class RockPaperScissors
{
    static void Main(string[] args)
    {
        Console.WriteLine("\tWelcome to the Rock Paper Scissors game!");

        PlayerManager.Player player = PlayerManager.InitializePlayer("\nEnter your nickname", "\nEnter your age");

        Console.WriteLine($"\nWelcome, {player.Nickname}! May the odds be ever in your favor!!");

        while(true)
        {
            PlayerManager.ShowPlayerInfo(player);

            if(!BattlePrepare.CheckReadyForBattle())
            {
                BattlePrepare.ExitGame();
                break;
            }

            Console.WriteLine("Here we go!");
        }
        
    }
}
