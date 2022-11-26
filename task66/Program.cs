// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSum(int M, int N)
{
    if (M == N) return M;
    return GetSum(M + 1, N - 1) + M + N;
}

Console.Clear();
Console.Write("Задайте первое число: ");
int givenNumber1 = int.Parse(Console.ReadLine()!);
Console.Write("Задайте второе число: ");
int givenNumber2 = int.Parse(Console.ReadLine()!);
if (givenNumber1 > givenNumber2)
{
    int sum = GetSum(givenNumber2, givenNumber1);
    Console.Write($"Сумма чисел от {givenNumber2} до {givenNumber1} равна {sum}.");
}
else
{
    int sum = GetSum(givenNumber1, givenNumber2);
    Console.Write($"Сумма чисел от {givenNumber1} до {givenNumber2} равна {sum}.");
}

