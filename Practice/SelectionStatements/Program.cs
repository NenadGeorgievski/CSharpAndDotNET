string password = "ninjaTurtle";

if(password.Length > 8)
{
    Console.WriteLine("Your password is strong.");
} else
{
    Console.WriteLine("Your password is too weak.");
}

object o = "3";
int j = 4;

if (o is int i)
{
    Console.WriteLine($"{i} x {j} = {i * j}");
}
else
{
    Console.WriteLine("o is not an integer so it cannot multiply");
}

int number = (new Random()).Next(1,7);

switch (number)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        goto case 1;
    case 3:
    case 4:
        Console.WriteLine("Three of four");
        goto case 1;
    case 5:
        goto A_Label;
    default:
        Console.WriteLine("This is the default value.");
        break;
}

Console.WriteLine("After end of switch statement");
A_Label:
Console.WriteLine("After A Label");