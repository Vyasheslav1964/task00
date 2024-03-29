﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int b= int.Parse("", CultureInfo.InvariantCulture);
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = GetCountDigits(number);
Console.Write($"Количество цифр в числе {number} = {count}");

int GetCountDigits(int num)
{
    if (num == 0) return 1;

    int counter = 0;
    while (num != 0)
    {
        num /= 10; // num = num / 10
        counter++; // counter = counter + 1;
    }
    return counter;
}