// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int digit = num;
// while (digit > 1000)
// {
// digit /= 10;
// }
// int thirdDigit = digit % 10;
// Console.WriteLine($"{num} -> " + thirdDigit);

int Prompt(string mess)
{
    Console.WriteLine(mess);
    string value  = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdDigital (int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

bool ValidateNum (int number)
{
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Ведите число");
if (ValidateNum(number))
{
    Console.WriteLine(GetThirdDigital (number));
}