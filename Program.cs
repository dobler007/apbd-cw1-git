using System;
using GitPractice;

int[] numbers = { 2, 4, 6 };

Console.WriteLine(Greeting.GetMessage());
Console.WriteLine($"Sum: {StatisticsHelper.CalculateSum(numbers)}");