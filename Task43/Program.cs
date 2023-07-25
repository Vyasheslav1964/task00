// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
int[] Enter()
{
    int[] array = new int[4];


    Console.WriteLine($"Введите число b1");
    array[0] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Введите число b2");
    array[1] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Введите число k1");
    array[2] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Введите число k2");
    array[3] = Convert.ToInt32(Console.ReadLine());
    
    return array;
}

double[] IntersectionPoint( int[] arr )
{
double x = (double)(arr[0]-arr[1]) / (arr[3]-arr[2]);
double y = (double)(arr[0]-arr[1])*arr[2] / (arr[3] - arr[2]) + arr[0] ;
double[] point = {x,y};
return point;
}

void PrintArray(double[] arr)
{
    Console.WriteLine($"Точка пересечения ({arr[0]} ; {arr[1]})");
}


Console.WriteLine("Введите коэфиценты b1, b2, k1, k2");
int[] arrCoeff = Enter();
double[] intersectionPoint = IntersectionPoint(arrCoeff);
PrintArray(intersectionPoint);