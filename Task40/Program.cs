// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Введите первую сторону треугольника: ");
int firstSide = int.Parse(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
int secondSide = int.Parse(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
int thirdSide = int.Parse(Console.ReadLine());

bool isTriangle = IsTriangleExists(firstSide, secondSide, thirdSide);
Console.WriteLine(isTriangle ? "Треугольник существует" : "Треугольник не существует");

bool IsTriangleExists(int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}