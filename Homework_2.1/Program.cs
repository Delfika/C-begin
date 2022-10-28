//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
int Number1 = new Random().Next(100,1000);
Console.WriteLine("Введенное число = "+Number1);
int SecondNumber=((Number1/10)%10);
Console.WriteLine("Второе цифра числа = "+SecondNumber);