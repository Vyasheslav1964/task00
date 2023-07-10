// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number *= -1;
}
if (number >= 100 && number <= 999)
{
int lastDijit = number % 10;
Console.Write($"Последняя цифра числа : {lastDijit}");
}
else
{
    Console.Write("Ошибка ввода");
}