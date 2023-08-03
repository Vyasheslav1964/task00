// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int PromptInt(string mess)
{
    Console.WriteLine(mess);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
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
        Console.WriteLine(" |");
    }
}
int[,] CreateMatrixyRndInt(int rows, int colums, int min, int max) // Для двумерного массива в сигнатуре указываются строки rows и столбцы colums.

{
    int[,] matrix = new int[rows, colums];              // Создали двумерный массив заполненный нулями. rows=3, colums=4.

    Random rnd = new Random();                          //Создали объект Random.
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);       // +1 потому что в методе Next интервал не включен
        }
    }
    return matrix;
}
 bool PossibilityOffMultiplication(int[,] matrix1, int[,] matrix2)
{
     if (matrix1.GetLength(1) == matrix2.GetLength(0)) return true;
   else return false;
           
}

int[,] MultiplicationOffMatrixs(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
            for(int k = 0; k < matrix2.GetLength(0); k++)
            matrixMult[i, j] = matrixMult[i,j] + matrix1[i,k] * matrix2[k,j];
           // Console.WriteLine(matrixMult[i, j]);
        }
    }
    return matrixMult;
}

int lenght = PromptInt("Количество строк: ");
int lenght1 = PromptInt("Количество столбцов: ");
int minim = PromptInt("Минимальное значение диапазона случайного числа");
int maxim = PromptInt("Максимальное значение диапазона случайного числа");
int[,] array1 = CreateMatrixyRndInt(lenght, lenght1, minim, maxim);
int lenght12 = PromptInt("Количество строк: ");
int lenght22 = PromptInt("Количество столбцов: ");
int minim22 = PromptInt("Минимальное значение диапазона случайного числа");
int maxim22 = PromptInt("Максимальное значение диапазона случайного числа");
int[,] array2 = CreateMatrixyRndInt(lenght12, lenght22, minim22, maxim22);
Console.WriteLine(" ");
if(PossibilityOffMultiplication(array1, array2))
{
Console.WriteLine("Первая матрица ");
Console.WriteLine(" ");
PrintMatrix(array1);
Console.WriteLine("Вторая матрица ");
Console.WriteLine(" ");
PrintMatrix(array2);
Console.WriteLine(" ");
Console.WriteLine(" Результирующая матрица будет :");
int[,] array3 = MultiplicationOffMatrixs(array1, array2);
Console.WriteLine(" ");
PrintMatrix(array3);
}
else Console.WriteLine("Матрицы нельзя перемножить");