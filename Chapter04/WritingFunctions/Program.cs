using static System.Console;

static void TimesTable(byte number)
{
	WriteLine($"This is the {number} times table: ");

	for (int row = 1; row <= 12; row++)
	{
		WriteLine($"{row} x {number} = {row * number}");
	}
}

TimesTable(5);

static decimal CalculateTax(decimal ammount, string twoLetterRegionCode)
{
	decimal rate = 0.0M;

	switch (twoLetterRegionCode.ToUpper())
	{
		case "CH":
			rate = 0.8M;
			break;
		case "DK":
		case "NO":
			rate = 0.25M;
			break;
		case "GB":
		case "FR":
			rate = 0.2M;
			break;
		case "HU":
			rate = 0.27M;
			break;
		case "OR":
		case "AK":
		case "MT":
			rate = 0.0M;
			break;
		case "ND":
		case "WI":
		case "ME":
		case "VA":
			rate = 0.05M;
			break;
		case "CA":
			rate = 0.0825M;
			break;
		default:
			rate = 0.06M;
			break;

	}
	return ammount * rate;


}

int productValue1 = 50;
decimal tax1 = CalculateTax(productValue1, "HU");
WriteLine($"The value of the product in Hungary is: {productValue1 + tax1}");

decimal tax2 = CalculateTax(productValue1, "ND");
WriteLine($"The value of the product in North Dakota is: {productValue1 + tax2}");

static string CardinalToOrdinal(int number)
{
	switch (number)
	{
		case 11:
		case 12:
		case 13:
			return $"{number}th";
		default:
			int lastDigit = number % 10;
			string suffix = lastDigit switch
			{
				1 => "st",
				2 => "nd",
				3 => "rd",
				_ => "th"
			};
			return $"{number}{suffix}";
	}
}

static void RunCardinalToOrdinal()
{
	for (int number = 1; number <= 40; number++)
	{
		Write($"{CardinalToOrdinal(number)} ");
	}
	WriteLine();
}

RunCardinalToOrdinal();

static int Factorial(int number)
{
	if (number < 1)
	{
		return 0;
	}
	else if (number == 1)
	{
		return 1;
	}
	else
		checked
		{
			int returnVal = Factorial(number - 1);
			int res = number * returnVal;
			return res;
			
		}
}

static void RunFactorial()
{
	for (int i = 1; i < 15; i++)
		try
		{
			WriteLine($"{i}! = {Factorial(i):N0}");
		}
		catch (OverflowException)
		{
			WriteLine($"{i} is too big for a 32-bit integer.");
		}
}

RunFactorial();
