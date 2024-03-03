// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");
//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25


int firstNumber, secondNumber;
char operation;

Console.Write("Input first number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Input operation: ");
 operation = Convert.ToChar(Console.ReadLine());


Console.Write("Input second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());

if (operation == '+')
{
    Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
}
else if (operation == '-')
{
    Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);
}
else if (operation == '*')
{
    Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);

}
else if (operation == '/')
{
    Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, firstNumber / secondNumber);

}
else
{
    Console.WriteLine("Wrong Character");

}
