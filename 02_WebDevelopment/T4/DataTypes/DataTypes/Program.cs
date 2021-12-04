// See https://aka.ms/new-console-template for more information

string text = "esto es un string";
int age = 23;
DateTime now = DateTime.Now;
double amount = 2.5;

string string2 = text + amount + now;

string string3 = string.Format("this is a string {0} this is an int {1} and this is a double {2}", text, age, amount);

string string4 = $"this is a string {text} and this is a date {now}";

char sampleChar = 'C';
char[] charArray = text.ToCharArray();

amount = 13 / (double)3;

DateTime date1 = new DateTime(2000, 1, 1);
var timestamp = now - date1;
TimeSpan  timespan = now - date1;

string test = "12";

age = int.Parse(test);

Console.WriteLine(age);
//Console.WriteLine(timestamp.Days);
Console.ReadKey();