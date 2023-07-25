// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] Enter(int value)
{
    int[] array = new int[value];
    for(int i = 0; i < value ; i++)
    {
        Console.WriteLine($"Введите число {i+1}");
         array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return array;
}
int numberOfInt(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr, int num)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}.  ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"]  -> {num}");
}
 Console.WriteLine("Сколько чисел вы хотите ввести");
 int m = Convert.ToInt32(Console.ReadLine());
 int[] array = Enter(m);
 int result = numberOfInt(array);
PrintArray(array, result);
