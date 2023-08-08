bool doContinue = true;
while(doContinue)
{
    Console.WriteLine("Enter a sentence:");
    string input = Console.ReadLine();
    string[] splitSentence = input.Split(" ");
    foreach(string s in splitSentence)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine("would you like to continue? (y/n)");
    string userinput = Console.ReadLine();
    if (userinput == "n") break;

}
bool doContinue2 = true;
List<string> words = new List<string>();
while(doContinue2)
{
    Console.WriteLine("enter some text");
    words.Add(Console.ReadLine());
    foreach(string s in words)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine("would you like to continue? (y/n)");
    string input = Console.ReadLine();
    if (input == "n") break;
    else if (input != "n" && input != "y") Console.WriteLine("Please enter a valid input.");
}