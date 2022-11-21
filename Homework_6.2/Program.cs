// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите переменные для первой прямой ");
Console.WriteLine("Введите значение b1 ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1 ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите переменные для второй прямой ");
Console.WriteLine("Введите значение b2 ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2 ");
double k2 = double.Parse(Console.ReadLine()!);
double X (double b1,double k1,double b2,double k2)
{
    double x = (b2-b1)/(k1-k2);
    return x;
}
double point1 = X(b1,k1,b2,k2);
double Y (double b2,double k2,double point1)
{
    double y = k2 * point1 + b2;
    return y;
}
double point2 = Y(b2,k2,point1);
Console.WriteLine($"Точка пересечения двух прямых = ({point1},{point2}) ");