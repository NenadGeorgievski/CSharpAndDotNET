using static System.Console;
using static System.Convert;

int a = 10;
double b = a; //an int can be safely converted to a double
WriteLine("{0} is of type {1}", b, b.GetType());

double c = 9.8;
int d = (int)c; //the compiler gives an error for converting a double to int

WriteLine("{0} is of type {1}", d, d.GetType());

double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}");

double[] doubles = new[] { 9.49, 9.88, 4.22, 233.2 };

foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new();
WriteLine(me.ToString());

//allocate array of 128 bytes
byte[] binaryObject = new byte[128];

//populate array with random bytes
(new Random()).NextBytes(binaryObject);

WriteLine("Binary object as bytes:");

for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X}");
}
WriteLine();

//convert to Base64 string and output as text
string encoded = ToBase64String(binaryObject);

WriteLine($"Binary object as Base64: {encoded}");

int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");
WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

WriteLine();

Write("How many eggs are there?");
string? input = ReadLine();

if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
} else
{
    WriteLine("I could not parse the input.");
}
 