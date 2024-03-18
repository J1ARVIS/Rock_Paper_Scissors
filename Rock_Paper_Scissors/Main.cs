using Rock_Paper_Scissors.GameLogic;

class RockPaperScissors
{
    internal struct Player
    {
        internal string Nickname;
        internal int Age;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("\tWelcome to the Rock Paper Scissors game!");

        Player player = new()
        { 
            Nickname = PlayerManager.RequestNickname("\nEnter your nickname"), 
            Age = PlayerManager.RequestAge("\nEnter your age")
        };

        Console.WriteLine($"\nWelcome, {player.Nickname}! May the odds be ever in your favor!!");

    }
}
