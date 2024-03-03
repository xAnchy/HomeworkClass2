// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;
using System;

Console.WriteLine("Hello, World!");
//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

int firstNumber, secondNumber, thirdNumber, fourthNumber;

Console.Write("Input first number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
thirdNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input fourth number: ");
fourthNumber = Convert.ToInt32(Console.ReadLine());

double result = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

Console.WriteLine("The average of {0}, {1}, {2}, {3} is {4}", firstNumber, secondNumber, thirdNumber, fourthNumber, result);