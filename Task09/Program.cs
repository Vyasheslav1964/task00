// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*int number = new Random().Next(10, 100 );
Console.WriteLine($"Случайное число диапазона 10 - 99 -> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit) Console.WriteLine($"Максимальная цифра числа {firstDigit}");
else Console.WriteLine($"Максимальная цифра числа {secondDigit}");*/

int number = new Random().Next(10, 100 );
Console.WriteLine($"Случайное число диапазона 10 - 99 -> {number}");
int maxDigit = MaxDigit (number);
Console.WriteLine($"Максимальная цифра числа {maxDigit}");

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
/*if (firstDigit > secondDigit) return firstDigit;
else return secondDigit;*/

return firstDigit > secondDigit ? firstDigit : secondDigit;

    
}