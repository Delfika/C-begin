﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вычесляем сколько символов в числе 
int Symbols (int a)
{
    int counter=0;
    while (a>0)
{
    a=a/10;
    counter++;
}
return counter; // число символов вернул
}
// Сумма чисел
int SumNumbers (int d, int a)
{
    int sum = 0;
    for (int i = 1; i <= d; i++)
    {
        sum = sum + a % 10; // нашли остаток от деления (число для сложения)
        a = a / 10; // отбрасываем одино число
    }
    return sum;
}
Console.WriteLine("Введите число:");
int a=int.Parse(Console.ReadLine()!); // Введенное число с клавиатуры
int d = Symbols(a); // переменной присваивается количество символов в переменной
int itog = SumNumbers(d,a); // переменной присваивается сумма чисел
Console.WriteLine("Сумма чисел = "+ itog);




