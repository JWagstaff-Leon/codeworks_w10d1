using w10d1.models;
RpsPlayer player = new RpsPlayer();
RpsPlayer computer = new RpsPlayer();
bool keepPlaying = false;
WinsDrawsLosses score = new WinsDrawsLosses();
Random rand = new Random();
do
{
    System.Console.Clear();
    switch(rand.Next(3))
    {
        case 0:
            computer.setSelection("rock");
            break;
        case 1:
            computer.setSelection("paper");
            break;
        case 2:
            computer.setSelection("scissors");
            break;
    }

    System.Console.WriteLine("\nRPS!\n");
    player.getMove();
    
    System.Console.Clear();
    if(player == computer)
    {
        System.Console.WriteLine("\nIt's a tie.");
        score.addDraw();
    }
    else if(player > computer)
    {
        System.Console.WriteLine("\nYou won!");
        score.addWin();
    }
    else
    {
        System.Console.WriteLine("\nYou lost.....");
        score.addLoss();
    }

    score.DrawScores();

    System.Console.Write("\nWould you like to keep playing? (y/n) ");
    keepPlaying = System.Console.ReadKey().KeyChar != 'n';
} while(keepPlaying);
System.Console.Clear();
score.DrawScores();