// See https://aia.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
int[,] ArrayStringInDescendingOder(int[,] matrixD)
{

    for (int i = 0; i < matrixD.GetLength(0); i++)  //цикл по строкам 
    {
        for (int j = 0; j < matrixD.GetLength(1); j++)
        {
            for (int l = 0; l < matrixD.GetLength(1); l++)
            {
                if (l + 1 == matrixD.GetLength(1))
                {
                    continue;
                }
                else
                {
                    if (l + 1 == matrixD.GetLength(1))
                    {
                        int temp = matrixD[i, l];
                        matrixD[i, l] = matrixD[i + 1, l];
                        matrixD[i + 1, l] = temp;
                    }
                    else
                    {
                        if (matrixD[i, l] < matrixD[i, l + 1])
                        {
                            int temp = matrixD[i, l];
                            matrixD[i, l] = matrixD[i, l + 1];
                            matrixD[i, l + 1] = temp;
                        }
                    }
                }
            }
        }
    }
    return matrixD;
}

int lenght = PromptInt("Количество строк: ");
int lenght1 = PromptInt("Количество столбцов: ");
int minim = PromptInt("Минимальное значение диапазона случайного числа");
int maxim = PromptInt("Максимальное значение диапазона случайного числа");
int[,] array = CreateMatrixyRndInt(lenght, lenght1, minim, maxim);
Console.WriteLine();
PrintMatrix(array);
array = ArrayStringInDescendingOder(array);
Console.WriteLine("");
Console.WriteLine("Измененный массив");
Console.WriteLine();
PrintMatrix(array);

