using static System.Console;

string password = "ninja";

if(password.Length < 8)
{
    WriteLine("Your password needs to contain at least 8 characters.");
} else
{
    WriteLine("Your password is strong.");
}

object o = "3";
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
} else
{
    WriteLine("o is not an in so it cannot multiply.");
}

int number = (new Random()).Next(1,7);
WriteLine($"My random number is {number}");

switch (number)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;

    case 3:
    case 4:
        WriteLine("Three or four.");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}

WriteLine("After end of switch.");
A_label:
WriteLine($"After A_label");