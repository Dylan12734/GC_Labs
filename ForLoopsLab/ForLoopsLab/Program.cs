bool doContinue = true;
while (doContinue)
{
    Console.WriteLine("Enter a number:");
    string userinput = Console.ReadLine();
    int input = 0;
    int.TryParse(userinput, out input);
    int final = 0;
    for(int i = 0; i<input; i++)
    {
         final = final + i;
    }
    Console.WriteLine(final);
    Console.WriteLine("Would you like to continue? (y/n)");
    string uI = Console.ReadLine();
    if (uI == "n")
    {
        Console.WriteLine("Goodbye");
        break;
    }
    
}