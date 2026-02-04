// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;
using MentorshipTodo.HelloWorld;

// Top-level statements (default .NET 6+) | Console App

Console.WriteLine("Hello, World!");

var text = "ekj";
char letter = 'b';
string textNew = "ekj";
string phrase = text + " " +  textNew;
string phraseTwo = $"Once upon {text} in the {textNew}, in a far far a way {true} and {7}";
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Phrase");
string result = stringBuilder.ToString();

DateOnly date = new DateOnly(2025, 2, 3);
string dateFormatted = date.ToShortDateString();
string dateFormattedLocal = date.ToString("D", new CultureInfo("pt-br"));
DateTime dateTime = new DateTime(2025, 2, 3, 12, 15, 4);
DateTime now = DateTime.Now;
DateTime today = DateTime.Today;
DateTime universalToday = DateTime.UtcNow;
DateTime newDateTime = universalToday.AddDays(1);
Console.WriteLine(newDateTime);

var anotherDate = DateTime.UtcNow.AddMonths(6);
// static readonly DateTime anotherDate = DateTime.UtcNow.AddMonths(6);
const int num = 1;
// object car = new Car();
// object numObject = (object)num;

int? idade = null;

DifficultLevel level = DifficultLevel.High;
Console.WriteLine(level);

int[] inteiros = new int[10];
int[] integers = [1, 4, 7];
int[,] table = new int[10, 10];
inteiros[0] = 1;
Console.WriteLine(inteiros[1]);

List<int> myIntegers = new List<int>();
myIntegers.Add(43);
myIntegers.Add(7);
Console.WriteLine(myIntegers.Count);
myIntegers.Remove(43);
Console.WriteLine(myIntegers[0]);
int firstElement = myIntegers.First();
myIntegers.Add(55);
myIntegers.Add(75);
int elementAt = myIntegers.ElementAt(1);
Console.WriteLine($"{elementAt} + {firstElement} = {elementAt + firstElement}");
myIntegers.RemoveAt(1);
myIntegers.Clear();

List<object> myObjects = new List<object>();
myObjects.Add("Rubel");
myObjects.Add(68);

Dictionary<int, string> myDictionary = new Dictionary<int, string>();
myDictionary.Add(0, "Nights");
myDictionary.Add(1, "Time");
myDictionary.Add(2, "Project");
myDictionary.Add(90, "Horizon");
string val = myDictionary[90];
Console.WriteLine(val);
bool containsKey = myDictionary.ContainsKey(2);
bool containsValue = myDictionary.ContainsValue("Coffee");
Console.WriteLine(containsValue || containsKey);

HashSet<int> myHashSet = new HashSet<int>();
myHashSet.Add(1);
myHashSet.Add(4);
myHashSet.Add(16);
myHashSet.Add(64);
myHashSet.Add(64);
Console.WriteLine(myHashSet.Count);

var mathOp = new MathOperations();
var mathResult = mathOp.Add(1, 9);
var mathResultNew = mathOp.Subtract(valor1: 3, valor2: 7);
Console.WriteLine(mathResultNew);
Console.WriteLine(mathOp.Multiply(9, 6));

var (quotient, msg) = mathOp.Divide(5, 2);
Console.WriteLine($"Quotient: {quotient}. {msg}");

var car = new Car
{
    ReleseadAt = new DateOnly(2021, 01, 01),
    Model = "Lambo",
    Color = Color.Red
};
car.Color = Color.Blue;
car.WriteModelName();
car.WriteCar();

if (car.Color == Color.Yellow)
{
    Console.WriteLine("Car color is Yellow ");
}
else if (car.Color == Color.Blue && myHashSet.Contains(64))
{
    Console.WriteLine("Car is Blue and myHashSet contains val 64");
}
else
{
    Console.WriteLine("Car is Red or Car is Blue and myHashSet does not contains val 64");
}

string writterName = car.Model == "Porsche" ? "Diego" : "Dieguito";
Console.WriteLine(writterName);

Color myColor = Color.Red;

switch (myColor)
{
    case Color.Red:
    {
        Console.WriteLine("Red");
    }
        break;
    case Color.Blue:
    {
        Console.WriteLine("Blue");
    }
        break;
    case Color.Yellow:
    {
        Console.WriteLine("Yellow");
    }
        break;
    default:
    {
        Console.WriteLine("New color");
    }
        break;
}

// "Ternary" Switch
int myNum = 7;
string myResult = myNum switch
{
    7 => "Diego",
    1 => "Dede",
    3 => "Nano",
    _ => "Unknown"
};
Console.WriteLine(myResult);

List<string> myList = new List<string> { "Diego", "Nano", "Dede" };     

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i]);
}

foreach (var name in myList)
{
    Console.WriteLine(name);
}

enum DifficultLevel
{
    Low,
    Medium,
    High
}