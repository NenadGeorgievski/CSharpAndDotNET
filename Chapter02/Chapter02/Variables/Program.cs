using System.Xml;

object name = "Amir";
object height = 1.7;
Console.WriteLine($"{name} is {height} meters tall.");

//int length1 = name.Length;
int length2 = ((string)name).Length;
Console.WriteLine($"{name} has {length2} characters.");

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

string[] myArray;
myArray = new string[4];

myArray[0] = "Jack";
myArray[1] = "Jones";
myArray[2] = "Tom";
myArray[3] = "Taylor";

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}
int[] broevi = new int[] { 1, 12, 233, 23 };
Console.WriteLine(broevi[3]);