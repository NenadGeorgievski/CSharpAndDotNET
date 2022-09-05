
using System.Security.Cryptography.X509Certificates;

string num1, num2;

Console.WriteLine("Please enter two numbers between 0 and 255. Start with the first one:");
num1 = Console.ReadLine();

try
{
	if(num1 == "apples" | num1 == "bananas")
	{
		throw new FormatException("The input doesn't match the required format.");
	}
}
catch (FormatException e)
{

	Console.WriteLine(e.Message);
}

Console.WriteLine("Now enter the second number:");
num2 = Console.ReadLine();

try
{
    if (num2 == "apples" | num2 == "bananas")
    {
        throw new FormatException("The input doesn't match the required format.");
    }
}
catch (FormatException e)
{

    Console.WriteLine(e.Message);
}

int intNum1 = Convert.ToInt32(num1);
int intNum2 = Convert.ToInt32(num2);

Console.WriteLine($"The result from divding {intNum1} with {intNum2} is {intNum1 / intNum2}");

x = 3 << 2;
Console.WriteLine(x);