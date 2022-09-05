int myNum = 12;

try
{
	Console.WriteLine($"{myNum} / 0 = {myNum / 0}");
}
catch (Exception ex)
{

	Console.WriteLine(ex.ToString());
}

double myDouble = 12.0;

try
{
	Console.WriteLine($"{myDouble} / 0 = {myDouble / 0}");
}
catch (Exception ex)
{

	Console.WriteLine(ex.ToString());
}

int intOverflow = int.MaxValue;

Console.WriteLine($"Min value of int is: {int.MinValue}");
Console.WriteLine($"Max value of int is: {int.MaxValue}");
Console.WriteLine($"Overflow of int by one million is is: {intOverflow + 1000000}");

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(i);
    if (i == 2)
	{
        break;
	}
}

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(i);
    if (i == 2)
    {
        continue;
    }
}
for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(i);
    if (i == 2)
    {
        return;
    }
}