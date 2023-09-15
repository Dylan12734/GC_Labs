namespace Roshambo_Lab;

public class HumanPlayer: Player
{
    public string Name { get; set; }
    public Opponents Choice(string name)
    {
        if (name == "The Rock"||name == "Dwayne 'The Rock' Johnson")
        {
            return Opponents.THE_ROCK;
        }
        else if (name == "Rando")
        {
            return Opponents.RANDO;
        }
        else return new Opponents();
    }
    public Roshambo PlayerThrow(string choice)
    {
        if(choice == "Rock"||choice == "rock"||choice == "ROCK")
        {
            return Roshambo.ROCK;
        }
        else if(choice == "Paper"||choice=="paper"||choice=="PAPER")
        {
            return Roshambo.PAPER;
        }
        else if (choice == "Scissors"||choice == "scissors"||choice == "SCISSORS")
        {
            return Roshambo.SCISSORS;
        }
        else return new Roshambo();
    }
}
