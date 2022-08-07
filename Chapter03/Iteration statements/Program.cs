using static System.Console;

int x = 0;

while (x<10)
{
    WriteLine(x);
    x++;
}

string? password;

do
{
    Write("Please enter a password:");
    password = ReadLine();
} while (password != "Pa$$w0rd");


WriteLine("Correct!");
for (int i = 1; i <= 10; i++)
{
    WriteLine(i);
}

string[] names = { "Andrew", "James", "Charlie", "Trpe" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}