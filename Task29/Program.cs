/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split())*/

Console.Write("Введите целые числа через пробел: ");
int[] myArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i]);
    if (i != myArray.Length - 1)
        Console.Write(", ");
}