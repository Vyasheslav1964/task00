// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsMultiplicity(number);
Console.WriteLine(result ? "да" : "нет");

bool IsMultiplicity(int num)
{
    if (num % 7 == 0 && num % 23 == 0) return true;
    return false;
}
