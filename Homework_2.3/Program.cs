// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число = ");
int Number1 = int.Parse(Console.ReadLine()!);
int []array={0,1,2,3,4,5,6,7};
int n=array[6];
int x=array[7];
if (Number1==n || Number1==x) Console.WriteLine("да");
else  Console.WriteLine("нет");