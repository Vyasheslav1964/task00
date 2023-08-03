// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
int[,] CreateMatrixyRndInt(int k, int begin) 

{
    int[,] matrix = new int[k ,k];             

       for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < k; j++)
        {
            matrix[i, j] = begin++; 
  
        }
    }
    for (int j = k-1; j < k; j++)
    {
        for (int i = 1; i < k; i++)
        {
            matrix[i, j] = begin++;
        }
    } 
    for (int i = k-1; i < k; i++)
    {
        for (int j = k- 2; j >= 0 ; j--)
        {
            matrix[i, j] = begin++;
        }
    }
    for (int j = 0; j < 1; j++)
    {
        for (int i = k-1; i > 0 ; i--)
        {
            matrix[i, j] = begin++;

        }
    
    }
    for (int i = 1; i < 2; i++)
    {
        for (int j = 1; j < k-1; j++)
        {
            matrix[i, j] = begin++;
            
        }
    }
        for (int i = 2; i < k-1; i++)
        {
            for (int j = 2; j > 0; j--)
            {
                matrix[i, j] = begin++;
          
            }
        }        
    
    
    return matrix;
}
int k1 = 4;
Console.WriteLine(" ");
int spir = PromptInt("Введите начало спирали");
int[,] arr = CreateMatrixyRndInt(k1, spir);
PrintMatrix(arr);

