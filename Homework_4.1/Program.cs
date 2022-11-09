// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Double Koren(double a,double b)
{ 
    double c = Math.Pow(a,b);
    return c;
}
Console.WriteLine("Введите число А:");
double a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B:");
double b = int.Parse(Console.ReadLine()!);
double result = Koren(a,b);
Console.WriteLine("Результат возведения А в степень В = "+result);