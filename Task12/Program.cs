// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());

int reminder = Multiplicity(numberFirst, numberSecond);

//if (reminder == 0) Console.WriteLine("Кратно");
//else Console.WriteLine($"не кратно остаток от деления равен {reminder}");
Console.WriteLine(reminder == 0 ? "кратно" : $"не кратно остаток от деления равен {reminder}");

int Multiplicity(int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}