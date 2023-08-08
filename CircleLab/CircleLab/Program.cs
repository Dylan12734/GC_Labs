using CircleLab;

Console.WriteLine("Please enter a number for the Radius.");
var userInput = Console.ReadLine();
double input = 0;
bool parsed = double.TryParse(userInput ,out input);
if (!parsed)
{
    Console.WriteLine("Error PLease enter a valid Input.");
}
Circle a = new Circle(input);
Console.WriteLine($"The Circles diameter is: {a.CalculateDiameter()}");
Console.WriteLine($"The Circles circumference is: {a.CalculateCircumfurence()}");
Console.WriteLine($"The Circles area is: {a.CalculateArea()}");
Console.WriteLine("Would you like to make the circle grow (Y/N)");
string userInput2 = Console.ReadLine();
if (userInput2 == "Y")
{
    a.Grow();
    Console.WriteLine(a.GetRadius());
}
else
{
    Console.WriteLine($"Goodbye! {a.GetRadius()}");
}

