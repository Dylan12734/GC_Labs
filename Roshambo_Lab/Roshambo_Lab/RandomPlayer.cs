namespace Roshambo_Lab;

public class RandomPlayer: Player
{
    public static string name = "Rando Calrissian";
    public Roshambo RandoPlayer()
    {
        Random random = new Random();
        int one = 1;
        int two = 2;
        int three = 3;
        if (one == random.Next())
        {
            return Roshambo.ROCK;
        }
        else if (two == random.Next())
        {
            return Roshambo.PAPER;
        }
        else if (three == random.Next())
        {
            return Roshambo.SCISSORS;
        }
        else return new Roshambo();
    }
}
