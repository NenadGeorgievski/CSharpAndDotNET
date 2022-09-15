Console.Write("Before parsing:");
Console.WriteLine("What is your age?");
string? input = Console.ReadLine();

try
{
	int age = int.Parse(input);
	Console.WriteLine($"You are {age} years old.");
}
catch(FormatException ex)
{
    Console.WriteLine($"FormatException says {ex.Message}");
}
catch(OverflowException)
{
	Console.WriteLine("Your number is in the proper format but it is too small or too large.");
}
catch (Exception ex)
{
	Console.WriteLine($"{ex.GetType()} says {ex.Message}");
}

Console.WriteLine("After parsing:");