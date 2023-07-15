// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <100 || number >999 ) Console.WriteLine("Ошибка ввода");
else
{

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число диапазона 100 - 999 -> {number}");

int secondDigit = SecondDigit (number);
Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}");
}

int SecondDigit (int num)
{
    return num / 10 % 10;
}

