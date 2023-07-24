// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

int Prompt(string mess)
{
    Console.WriteLine(mess);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int Exponentiation(int num1, int num2)
{
    int count = 1;
    int result = 1;
    while (count <= num2)
    {
       result = result*num1;
        count++;
       // Console.WriteLine($"{result} -> {count}" );
    }
    return result;
}

int a = Prompt("Введите число основание степени");
int b = Prompt("Введите степень числа");

if (b<0)
{
   Console.WriteLine("Ошибка ввода");
}
 else
 {

 
int c = Exponentiation(a, b);
    Console.WriteLine($"{a}, {b} -> {c}");
 }