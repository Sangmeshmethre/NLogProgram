// See https://aka.ms/new-console-template for more information
using NLogs;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter first number");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Plese enter second number");
int second = Convert.ToInt32(Console.ReadLine());
Addition.Sum(first, second);
