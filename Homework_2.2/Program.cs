// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число = ");
int Number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введенное число = "+ Number1);
int n=(Number1 % 1000)/100;
if (n>0)Console.WriteLine(n);
if (n==0) Console.WriteLine("третьей цифры нет");



