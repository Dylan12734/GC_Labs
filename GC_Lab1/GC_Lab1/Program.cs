Console.WriteLine("Please enter an integer between 1 and 100");
string input = Console.ReadLine();
int i = 0;
int.TryParse(input, out i);
if (i < 60 & i % 2 == 1)
{
    Console.WriteLine("The number entered is odd and less than 60");
}
else if (i >= 2 && i <= 24 & i % 2 ==0)
{
    Console.WriteLine("The number entered is less than 25 and even");
}
else if (i >= 26 && i <= 60 & i % 2 == 0)
{
    Console.WriteLine("The number entered is even and between 26 and 60");
}
else if (i > 60 & i % 2 == 0)
{
    Console.WriteLine("The number entered is above 60 and even"); 
}
else if (i > 60 & i % 2 == 1)
{
    Console.WriteLine("The number entered is odd and greater than 60");
}