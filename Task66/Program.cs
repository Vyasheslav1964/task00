// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int NaturalNumbersSum(int m, int n)
{
    int sum = 0;
    if (m > n)
    {

        sum = m +  NaturalNumbersSum(m - 1, n);
        return sum;
    }
    else if (m < n)
    {
        sum = m + NaturalNumbersSum(m + 1, n);
        return sum;
    }
    else
    {
        sum = m;
        return sum;
    }
}

Console.WriteLine("Input number 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Incorrect numbers");
    return;
}
 int result = NaturalNumbersSum(number1, number2);
Console.WriteLine($"M = {number1} ; N = {number2} ; ->  {result} ");
