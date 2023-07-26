// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int PromptInt(string mess)
{
    Console.WriteLine(mess);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double[,] CreateMatrixRndDoubl(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
            if (matrix[i,j] < 0)
                matrix[i,j] = rnd.Next(min, max + 1) - rnd.NextDouble();
            else matrix[i,j] = rnd.Next(min, max + 1) + rnd.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("     ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i,j], 2),4} ");
        }
        Console.WriteLine("    ");
    }
}
int lenght = PromptInt("Количество строк: ");
int lenght1 = PromptInt("Количество столбцов: ");
int minim = PromptInt("Минимальное значение диапазона случайного числа");
int maxim = PromptInt("Максимальное значение диапазона случайного числа");
double[,] arraymn = CreateMatrixRndDoubl(lenght, lenght1,  minim, maxim);
PrintMatrix(arraymn);





