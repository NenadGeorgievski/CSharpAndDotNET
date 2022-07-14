// See https://aka.ms/new-console-template for more information
//using System.Reflection;
//System.Data.DataSet ds;
//HttpClient client;

//Assembly? assembly = Assembly.GetEntryAssembly();
//if (assembly == null) return;

//foreach(AssemblyName name in assembly.GetReferencedAssemblies())
//{
//    Assembly a = Assembly.Load(name);

//    int methodCount = 0;

//    foreach(TypeInfo t in a.DefinedTypes)
//    {
//        methodCount += t.GetMethods().Count();
//    }

//    Console.WriteLine(
//        "{0:N0} types with {1:N0} methods in {2} assembly.",
//        arg0: a.DefinedTypes.Count(),
//        arg1: methodCount, arg2: name.Name);
//}
//For strings a single letter is stored as a char type

char letter = 'A';
char symbol = '$';
char digit = '1';

Console.WriteLine($"{nameof(letter)} : {letter} \r \n" + 
    $"{nameof(digit)} : {digit} \r\n" +
    $"{nameof(symbol)} : {symbol} ");

//Working with strings
string firstName = "Nenad";
string lastName = "Georgievski";
string phoneNumber = "223305";

Console.WriteLine($"{nameof(firstName)} : {firstName} \r\n"  +
                   $"{nameof(lastName)} : {lastName} \r\n" + 
                   $"{nameof(phoneNumber)} : {phoneNumber}");

string fullNameWithTabSeparator = "Nenad\tGeorgievski";
Console.WriteLine(fullNameWithTabSeparator);

string filePath = @"C:\television\stored.txt";
Console.WriteLine(filePath);