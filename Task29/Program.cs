See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
// int[] array = new int[8];
// FillArray(array);
// PrintArray(arra



// int Promt(string message)
// {
//     System.Console.WriteLine(message);//выводим приглашение к вводу
//     string ReadInput = Console.ReadLine();
//     int resault = int.Parse(ReferenceEqualseadInput);//приводим к числу
//     return resault;
// }
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
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int lenght = Prompt("Длина массива: ");
int minim = Prompt("Минимальное значение диапазона случайного числа");
int maxim = Prompt("Максимальное значение диапазона случайного числа");

int[] array = CreateArrayRndInt(lenght, minim, maxim);
PrintArray(array);
