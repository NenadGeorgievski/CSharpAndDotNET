//int max = 500;

//for (byte i = 0; i < max; i++)
//{
//    Console.WriteLine(i);
//}

for (int j = 0; j <= 100; j++)
{
    if((j % 3 == 0) & (j % 5 == 0))
    {
        
        Console.WriteLine("FizzBuzz");
    } else if(j % 3 == 0)
    {
        Console.WriteLine("Fizz");
    } else if(j % 5 == 0)
    {
        Console.WriteLine("Buzz");
    } else
    {
        Console.WriteLine(j);
    }
}