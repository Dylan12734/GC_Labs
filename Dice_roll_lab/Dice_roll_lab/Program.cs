using Dice_roll_lab;
bool doContinue = true;
while (doContinue)
{
    Console.WriteLine("How many sides are on the dice you would like to roll?");
    string answer = Console.ReadLine();
    Console.WriteLine("Roll the dice");
    int answerNum = 0;
    int.TryParse(answer, out answerNum);
    int d1 = TheGuts.rng(answerNum);
    int d2 = TheGuts.rng(answerNum);
    Console.WriteLine($"The result for die 1 is :{d1}");
    Console.WriteLine($"The result for die 2 is :{d2}");
    int total = d1 + d2;


    if ((answerNum == 6 && total == 7) || (answerNum == 6 && total == 11))
    {
        Console.WriteLine("WIN!!!!");
    }
    else if ((answerNum == 6 && total == 2) || (answerNum == 6 && total == 3) || (answerNum == 6 && total == 12))
    {
        Console.WriteLine("Craps");
    }
    if (answerNum == 6 && d1 == 1 && d2 == 1)
    {
        Console.WriteLine("Snake Eyes");
    }
    else if ((answerNum == 6 && d1 == 1 && d2 == 2) || (answerNum == 6 && d1 == 2 && d2 == 1))
    {
        Console.WriteLine("Ace Deuce");
    }
    else if (answerNum == 6 && d1 == 6 && d2 == 6)
    {
        Console.WriteLine("Box Cars");
    }
    Console.WriteLine("Do you wish to continue? (y/n)");
    string userInput = Console.ReadLine();
    if (userInput == "n")
    {
        break;
    }
}