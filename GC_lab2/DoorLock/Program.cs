bool doorLocked = true;
int doorCode = 13579;
int attempts = 4;
do
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
while (doorLocked = true);