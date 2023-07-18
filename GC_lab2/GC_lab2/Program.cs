bool doContinue = true;
while (doContinue = true)
{
    Console.WriteLine("Hello World");
    Console.WriteLine("Would you like to continue? (y/n)");
    string answer = Console.ReadLine();
    if (answer == "n")
    {
        Console.WriteLine("Goodbye");
        break;
    }
}
bool doContinue2 = true;
while (doContinue2 = true)
{
    Console.WriteLine("Enter a number");
    string input = Console.ReadLine();
    int number = 0;
    int.TryParse(input, out number);
    for (int i = 0;i < number + 1; i++)
    {
        Console.WriteLine(i);
    }
    for(int e = number ;e > -1; e --)
    {
        Console.WriteLine(e);
    }
    Console.WriteLine("Would you like to continue? (y/n)");
    string answer2 = Console.ReadLine();
    if (answer2 == "n")
    {
        Console.WriteLine("Goodbye");
        break;
    }
}
bool doorLocked = true;
int doorCode = 13579;
int attempts = 4;
while (doorLocked  = true)
{
    Console.WriteLine("Please enter the door lock code");
    string userinput = Console.ReadLine();
    int ui = 0;
    int.TryParse(userinput, out ui);
    if (ui == doorCode)
    {
        Console.WriteLine("Welcome");
        break;
    }
    else if (attempts == 0)
    {
        Console.WriteLine("too many attempts at entry try again later");
        break;
    }
    else
    {
        attempts--;
    }
}

