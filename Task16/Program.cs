// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Введите первое число");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второе число");
int numberSecond = Convert.ToInt32(Console.ReadLine());

bool result = IsSquare(numberFirst, numberSecond);
Console.WriteLine(result ? "да" : "нет");

bool IsSquare (int num1, int num2)
{
  return num1 == num2 * num2 || num2 == num1*num1;
}