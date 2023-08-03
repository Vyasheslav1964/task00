// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0) 27(0, 0, 1) 90(0, 1, 1)
// 34(1, 0, 0) 41(1, 1, 0) 26(1, 0, 1) 55(1, 1, 1)
int PromptInt(string mess)
{
    Console.WriteLine(mess);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[,,] CreateMatrixyRndInt(int rows, int colums, int tree) // Для двумерного массива в сигнатуре указываются строки rows и столбцы colums.

{
    int[,,] matrix = new int[rows, colums, tree];
    int numD = 10;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = numD++;
                }

            }
        }
        return matrix;
    //}
}
void PrintMatrixThree(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
     
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],5} ({i}, {j}, {k} )");
            }
         
        }
        Console.WriteLine(" ");
    }
}
Console.WriteLine("Введите размерности массива :");
int first = PromptInt("Первая: ");
int second = PromptInt("Вторая: ");
int third = PromptInt("Третья:");

if (first * second * third > 90)
{
    Console.WriteLine("Массив создать нельзя");
   

}
else
{
    int[,,] array =CreateMatrixyRndInt(first, second, third) ;
PrintMatrixThree(array);
}
