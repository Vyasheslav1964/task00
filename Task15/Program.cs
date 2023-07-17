// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string mess)
{
    Console.WriteLine(mess);
    string value  = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

string WeekDay (int num)
{
    return num == 6 || num == 7 ? $" {num} -> да" :  $" {num} -> нет";
}

bool ErrorEnter(int num)
{
    if (1 > num || num > 7)
    {
        Console.WriteLine("Ошибка ввода ");
        return false;
    }
    return true;

}

string message = "Введите номер дня недели";
int numer = Prompt(message);
//ErrorEnter(numer);
if (ErrorEnter(numer)) Console.WriteLine(WeekDay(numer));

