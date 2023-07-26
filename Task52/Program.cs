// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] CreateMatrixRndInt()
{

    Random rnd = new Random();
    int rows = rnd.Next(2, 6);
    int columns = rnd.Next(2, 7);
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
double[] Awerage(int[,] mat)
{
    double[] averageColumn = new double[mat.GetLength(1)];


    for (int j = 0; j < mat.GetLength(1); j++)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            averageColumn[j] += (double)mat[i, j] / mat.GetLength(0);

        }
    }
    return averageColumn;
}
void PrintAwerageColum(double[] mat1)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < mat1.Length; i++)
    {
        Console.Write($" {Math.Round(mat1[i], 2)}; ");
    }
}
int[,] array = CreateMatrixRndInt();
double[] array1 = Awerage(array);
PrintMatrix(array);
PrintAwerageColum(array1);
