// See https://aka.ms/new-console-template for more information
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212->нет

// 12821->да

// 23432->да
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = NonNegativ(number);

if (number < 10000 || number > 99999) Console.WriteLine("Ошибка ввода");
else Console.Write(Polindrom(number));


int NonNegativ(int num)
{
    if (num < 0) return num = -num;
    else return num;
}

string Polindrom(int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10) return $"{num}-> да";
    else return $"{num}-> нет";
}
