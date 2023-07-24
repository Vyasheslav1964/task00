// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Prompt(string mess)
{
    Console.WriteLine(mess);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// int NumberDijits(int num)
// {
//     int count = 0;

//     while (num > 0)
//     {
//         num /= 10;
//         count++;
//     }
//     return count;

// }

int SumDijits(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int number = Prompt("Введите число");
// int dijits = NumberDijits(number);
// Console.WriteLine(dijits);
int sumDijits = SumDijits(number);
Console.WriteLine(sumDijits);
