// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число диапазона 100 - 999 -> {number}");
/*int firstDigit = number / 100;
int secondDigit = number % 10;
int resultDijit = firstDigit *10 + secondDigit;
Console.WriteLine($"{number} -> {resultDijit}");*/
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число диапазона 100 - 999 -> {number}");
int result = DeleteSecondDijit(number);
Console.WriteLine($"{number} -> {result}");
int DeleteSecondDijit (int num)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    int resultDijit = firstDigit * 10 + secondDigit;
    return resultDijit;
}