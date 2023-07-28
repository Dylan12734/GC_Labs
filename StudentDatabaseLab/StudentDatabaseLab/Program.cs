string[] studentNames = new string[9] { "Sally", "Paul", "George", "Rich", "Frank", "Monica", "Rachelle", "Giuseppe", "Kait" };
string[] hometowns = new string[9] {"Albion", "Trenton", "Ann Arbor", "Southgate" ,"Wyandotte", "Lansing", "Royal Oak", "Marquette", "Petoskey" };
string[] favoriteFood = new string[9] {"Spaghetti", "Croissant", "Pocky", "Twizzlers", "Graham Crackers", "Apples", "Pizza", "Granola and Yogurt", "Lasgna"};
bool doCOntinue = true;

while (doCOntinue)
{
    Console.WriteLine("Welcome, who would you like to know more about? Enter a number form 1-9:");
    string userInput = Console.ReadLine();
    int input = 0;
    bool worked = int.TryParse(userInput, out input); 
    if (worked)
    {
        Console.WriteLine($"Student number {input} is {studentNames[input-1]}");
    }
    else
    {
        Console.WriteLine("Please enter a valid input");
    }
    Console.WriteLine("What would you like to know? Enter 'hometown' or 'favorite food':");
    string userInput2 = Console.ReadLine();
    if(userInput2 == "hometown")
    {
        Console.WriteLine($"{studentNames[input-1]} is from {hometowns[input-1]}");
    }
    else if(userInput2 == "favorite food")
    {
        Console.WriteLine($"{favoriteFood[input-1]} is {studentNames[input-1]}'s favorite food.");
    }
    else
    {
        Console.WriteLine("Please enter a valid input");
    }
    Console.WriteLine("Would you like to look at another student? (y/n)");
    string userInput3 = Console.ReadLine();
    if (userInput3 == "n") break;

}