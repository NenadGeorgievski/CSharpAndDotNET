int x = 0;

while(x <  10)
{
    Console.WriteLine(x);
    x++;
}

string? password;

do
{
    Console.WriteLine("Please enter your password:");
    password = Console.ReadLine();  
} while (password != "Pa$$w0rd");
Console.WriteLine("Correct!");

for (int y = 0; y <= 10; y++)
{
    Console.WriteLine(y);
}
string[] names = { "Adam", "Charlie", "Barry" };

foreach (string  name in names)
{
    Console.WriteLine($"{name} has {name.Length} characeters.");
}