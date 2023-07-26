// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7->такого элемента в массиве нет
int PromptInt(string mess)
{
    Console.WriteLine(mess);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,] CreateMatrixRndInt()
{
    // 
    Random rnd = new Random();
    int rows = rnd.Next(2,5); 
    int columns = rnd.Next(2,6);                   
    int[,] matrix = new int[rows, columns]; // rows = 2-4, columns = 2-5
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("  |");
    }
}
void Search(int row, int column, int[,] arr)
{
    if (row < 0 || column < 0) Console.WriteLine("Ошибка ввода");
    else 
    if (row >= arr.GetLength(0) || column >= arr.GetLength(1))
     Console.WriteLine($"{row}, {column} -> такого элемента нет");
     else Console.WriteLine($"Этот элемент -> {arr[row, column]}");
}


int[,] arrayRandomInt = CreateMatrixRndInt();
int rows = PromptInt("Введите номер строки: ");
int columns = PromptInt("Введите номер столбца: ");
Search(rows, columns, arrayRandomInt);

PrintMatrix(arrayRandomInt);