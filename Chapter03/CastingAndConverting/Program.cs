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