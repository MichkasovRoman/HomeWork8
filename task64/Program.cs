// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

string GetReverseOrder(int number)
{
    if (number == 1) return number.ToString() + ".";
    return $"{number}, " + GetReverseOrder(number - 1); 
}

Console.Clear();
Console.Write("Задайте натуральное число: ");
int givenNumber = int.Parse(Console.ReadLine()!);
string resultString = GetReverseOrder(givenNumber);
Console.WriteLine(String.Empty);
Console.WriteLine($"Натуральные числа в промежутке от {givenNumber} до 1 по убыванию: ");
Console.Write(resultString);