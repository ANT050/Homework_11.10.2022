/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int GetNumber(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}
Console.WriteLine("");

int SumDigitsNumber(int number)
{
    int result = 0, remains;
    for (int i = number; number > 0; number = number / 10)
    {
        remains = number % 10;
        result += remains;
    }
    return result;
}

int number = GetNumber("Введите число: ");
Console.WriteLine("");

int result = SumDigitsNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} = {result}\n");
