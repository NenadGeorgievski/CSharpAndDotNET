
//unsigned positive whole number or 0 is called uint

uint a = 122;

//integer means positive or negative whole number

int b = -12;

//float means single precision floating point
//F suffix makes it a float literal

float c = 1.1F;

//double means double precision floating point

double d = 1.1; //double literal

Console.Write($"{nameof(a)} is an unsigned integer {a} \r\n" + 
              $"{nameof(b)} is a whole number {b} \r\n" + 
              $"{nameof(c)} is a float {c} \r\n" + 
              $"{nameof(d)} is a double precision number {d}");
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
Console.WriteLine("\r\n");
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{binaryNotation == hexadecimalNotation}");
Console.WriteLine(decimalNotation);
Console.WriteLine(binaryNotation);
Console.WriteLine(hexadecimalNotation);

Console.WriteLine($"int uses {sizeof(int)} bytes and stores numbers in the range of {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"float uses {sizeof(float)} bytes and stores numbers in the range of {float.MinValue:N0} to {float.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and stores numbers in the range of {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

//using doubles, this expression will evaluate to false because 0,1 stored as double is not exact in memory
double x = 0.1;
double y = 0.2;

if(x + y == 0.3)
{
    Console.WriteLine($"{x} + {y} equals {0.3}");
} else
{
    Console.WriteLine($"{x} + {y} does not equal to {0.3}");
}

//using decimal

decimal num1 = 0.1M;
decimal num2 = 0.2M;

if(num1 + num2 == 0.3M)
{
    Console.WriteLine($"{num1} + {num2} equals to {0.3M}");
} else
{
    Console.WriteLine($"{num1} + {num2} does not equal to {0.3M}");
}