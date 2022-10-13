/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/


int GetNumber(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

Console.WriteLine("");
int FirstDegreeSecond(int ferstNumber, int secondNumber)
{
    int result = 1;
    for (int i = 1; i <= secondNumber; i++)
    {
        result *= ferstNumber;
    }
    return result;
}

int ferstNumber = GetNumber("Введите число: ");
int secondNumber = GetNumber("Введите степень: ");
Console.WriteLine("");

int result = FirstDegreeSecond(ferstNumber, secondNumber);
Console.WriteLine($"Результат: {ferstNumber}, {secondNumber} -> {result} ({ferstNumber}^{secondNumber})\n");
