// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int PromptInt(string mess)
{
    Console.WriteLine(mess);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}



double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            arr[i] = rnd.Next(min, max + 1) - rnd.NextDouble();
        else arr[i] = rnd.Next(min, max + 1) + rnd.NextDouble();
    }
    return arr;
}
void PrintArray1(double[] arr, double num)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}.  ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"]  => {num}");
}
double Different(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    result = max - min;
    return result;
}



void PrintArrayRound(double[] arr, double num)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 2)}.  ");
        else Console.Write($"{Math.Round(arr[i], 2)}");
    }
    Console.WriteLine($"]  => {Math.Round(num, 2)}");
}


int lenght = PromptInt("Длина массива: ");
int minim = PromptInt("Минимальное значение диапазона случайного числа");
int maxim = PromptInt("Максимальное значение диапазона случайного числа");
double[] arrayDouble = CreateArrayRndDouble(lenght, minim, maxim);
double different = Different(arrayDouble);
PrintArray1(arrayDouble, different);
Console.WriteLine("С округлением");
PrintArrayRound(arrayDouble, different);
