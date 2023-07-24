// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0
int Prompt(string mess)
{
    Console.WriteLine(mess);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray1(int[] arr, int num)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"]  -> {num}");
}
int SumOddElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if ((i+1) % 2 == 0) count += arr[i];
    }
    return count;
}

int lenght = Prompt("Длина массива: ");
int minim = Prompt("Минимальное значение диапазона случайного числа");
int maxim = Prompt("Максимальное значение диапазона случайного числа");
int[] array = CreateArrayRndInt(lenght, minim, maxim);
int sum = SumOddElements(array);
PrintArray1(array, sum);