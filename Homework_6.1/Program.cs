//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  
Console.Write("Введите колличество чисел, которое вы хотите задать ");
int numbers = int.Parse(Console.ReadLine()!);
int []Array = new int [numbers];
int count=0;
void Fill(int []Array)
{
for (int i=0; i <Array.Length;i++)
{
    Console.WriteLine("Введите число ");
    Array[i]=int.Parse(Console.ReadLine()!);
    if (Array[i]>0) count++ ;
}
}
// void Print(int []Array)
// { 
//     for (int i=0;i<Array.Length;i++)
//     Console.WriteLine(Array[i]);
// } 
Fill(Array);
Console.WriteLine($"Количество чисел > 0 = {count}");









// Console.WriteLine("Вывод чисел");
// Print (Array);
// Console.WriteLine("Вывод чисел");
// for (int i =0; i<Array.Length;i++)
// {
//     Console.WriteLine(Array[i]);
// }
// Console.WriteLine($"Количество чисел больше 0 = {count}");