﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8
//Осторожно, спойлер! return degr == 0 ? 1 : num1* Pow(num1, num2 - 1);
// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(10));
Console.WriteLine("Enter number A");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B");
int numB = Convert.ToInt32(Console.ReadLine());

int pow = Pow(numA, numB);
Console.WriteLine(pow);

int Pow(int num1, int num2)
{
    if (num2 == 0) return 1; // 3-5, 3-4, 3-3, 3-2, 3-1
    return num1 * Pow(num1, num2 - 1); // 3*3*3*3*3*1 = 243

}