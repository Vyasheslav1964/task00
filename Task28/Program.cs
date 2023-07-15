// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int Fact = FactNumbers(number);
Console.WriteLine($"произведение чисел в диапазоне от 1 до {number} = {Fact}");

int FactNumbers(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum *= i; // sum = sum + i;
    }
    return sum;
}