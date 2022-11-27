// Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetAckermanFunction(int number1, int number2) //GetAckermannValue(int number1, int number2)
{
    
    if (number1 == 0) return number2 + 1;
    else if (number2 == 0)  return GetAckermanFunction(number1 - 1, 1);
    return GetAckermanFunction(number1 - 1, GetAckermanFunction(number1, number2 - 1));
}

Console.Clear();
Console.Write("Введите первое число: ");
int givenNumber1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int givenNumber2 = int.Parse(Console.ReadLine()!);
int resultAckerman = GetAckermanFunction(givenNumber1, givenNumber2);
Console.Write($"Значение функции Аккермана для введенных вами чисел равно {resultAckerman}");
