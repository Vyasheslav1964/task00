// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.Write("Yes");
}
else
{
    Console.Write("no");
}