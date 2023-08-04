// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))

int Akkerman (int m, int n)
{ 
    if (m == 0) return n+1;
    else 
    if (n == 0) return Akkerman(m - 1, 1);
    
    else
    {
      return  Akkerman(m - 1, Akkerman(m, n - 1)); 
    }
}

Console.WriteLine("Input number 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(number1, number2);
Console.WriteLine($"m = {number1} ; n = {number2} -> A(m, n) = {result} ");