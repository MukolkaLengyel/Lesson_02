//Math Problems

char a = 'x';
char b = 'y';

var mathProblem1 = -6 * Math.Pow(a, 3) + 5 * Math.Pow(a, 2) - 10 * a +15;
var mathProblem2 = Math.Abs(a) * Math.Sin(a);
var mathProblem3 = 2 * Math.PI * a;
var mathProblem4 = Math.Max(a, b);

Console.WriteLine("First math problem sollution is: " + mathProblem1);
Console.WriteLine("Second math problem sollution is: " + mathProblem2);
Console.WriteLine("Third math problem sollution is: " + mathProblem3);
Console.WriteLine("Fourth math problem sollution is: " + mathProblem4);

//DateTime Problem

var toNewYear = new DateTime(2023, 12, 31);
var passedNewYear = new DateTime(2023, 5, 3);
var time = new TimeSpan(13, 09, 02);



Console.WriteLine(toNewYear - passedNewYear - time + " days passed from New Year");
Console.WriteLine(toNewYear + " days left to New Year");