// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (number_2 > max)
    max = number_2;
if (number_3 > max)
    max = number_3;

Console.WriteLine($"{number_1} {number_2} {number_3} -> {max}");


