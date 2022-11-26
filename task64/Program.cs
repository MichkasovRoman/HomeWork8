// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string GetReverseOrder(int number)
{
    if (number == 1) return number.ToString();
    else
    return $"{GetReverseOrder(number - 1)}"; 
}

Console.Clear();
int m = int.Parse(Console.ReadLine()!);
string a = GetReverseOrder(m);
Console.Write(a);