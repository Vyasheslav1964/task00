// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int Prompt(string mess)
{
    Console.WriteLine(mess);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int NumberOfEvenNambers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
         if (arr[i]%2 == 0) count++;
    }
    return count;
}

void PrintArray(int[] arr, int num)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine($"]  -> {num}");
}
int lenght = Prompt("Длина массива: ");
int[] array = CreateArrayRndInt(lenght);
int numberEven = NumberOfEvenNambers(array);
PrintArray (array, numberEven);
//Console.Write($" -> {numberEven}");