// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void PrintMatrixOne(int[] matrix1)
{


    Console.Write("[");
    for (int i = 0; i < matrix1.Length; i++)
    {
        {
            Console.Write($"{matrix1[i],5}");
        }
        
        }
     Console.WriteLine("]");
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
    int[] SumElemString(int[,] ar)
    {
        int[] sum = new int[ar.GetLength(0)];
        for (int i = 0; i < ar.GetLength(0); i++)
        {
            for (int j = 0; j < ar.GetLength(1); j++)
            {
                sum[i] += ar[i, j];
               
            }
        }
        return sum;
    }
    int SumStringMix(int[] ar)
    {
        int sumMax = ar[0];
        int index = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            if(sumMax > ar[i]) index = i;
            
        }
        return index;
    }
int lenght = PromptInt("Количество строк: ");
int lenght1 = PromptInt("Количество столбцов: ");
int minim = PromptInt("Минимальное значение диапазона случайного числа");
int maxim = PromptInt("Максимальное значение диапазона случайного числа");
int[,] array = CreateMatrixyRndInt(lenght, lenght1, minim, maxim);
Console.WriteLine(" ");
PrintMatrix(array);
Console.WriteLine(" ");
Console.WriteLine(" ");
int[] arrSum = SumElemString(array);
PrintMatrixOne(arrSum);
Console.WriteLine(" ");
int stringSumMix = SumStringMix(arrSum);
Console.WriteLine(" ");
Console.WriteLine($"Номер строки с наименьшей суммой  {stringSumMix}");

