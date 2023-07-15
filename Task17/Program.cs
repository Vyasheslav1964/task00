// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
//int num = 644764;
// int digit1 = num /100000;
// int digit2 = num / 10000 % 10;
// int digit3 = num / 1000 % 10;

// int digit4 = num / 100 % 10;
// int digit41 = num % 1000 / 100; //644764 % 1000 = 764 / 100 = 7.64

// int digit5 = num / 10 % 10;
// int digit51 = num % 100 / 10; // 6447_64 % 100 = 64 /10 = 6.4
Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = GetQuarter(xCoordinate, yCoordinate);
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти -> {quarter}" 
                : "Введены некорректные координаты";

Console.WriteLine(result);

int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}