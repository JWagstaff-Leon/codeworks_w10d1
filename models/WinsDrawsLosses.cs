namespace w10d1.models
{
    public class WinsDrawsLosses
    {
        public int Wins { get; private set; }
        public int Draws { get; private set; }
        public int Losses { get; private set; }

        public int addWin()
        {
            Wins += 1;
            return Wins;
        }
        public int addDraw()
        {
            Draws += 1;
            return Draws;
        }
        public int addLoss()
        {
            Losses += 1;
            return Losses;
        }

        public void DrawScores()
        {
            System.Console.WriteLine($"\nWins: {Wins}");
            System.Console.WriteLine($"Losses: {Losses}");
            System.Console.WriteLine($"\nTies: {Draws}");
        }
    }
}