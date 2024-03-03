// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

//Console.WriteLine("Hello, World!");
//variable has the second value and the second variable the first value. Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

int firstNumber, secondNumber, temporaryNumber;


Console.Write("Input first number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());

temporaryNumber = firstNumber;
firstNumber = secondNumber;
secondNumber = temporaryNumber;

Console.WriteLine("After swapping: \n First number: " + firstNumber + "\n Second number: " + secondNumber);


1