// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("Введите число: ");
int N=int.Parse(Console.ReadLine()!);
int[] GetSqrtTable(int N) // метод объявления массива с N-кол-вом массива
{
int[] SqrtArray = new int[N]; // объявление массива с Н значениями, по умолчанием у int получится 0,

for (int i = 0,number = 1; i < N; i++,number++)
{
SqrtArray[i] = number * number *number; // вычесление значения в кубе
}
return SqrtArray;
}

void PrintTable(int[] Array)
{
int number = 1;
for (int i = 0; i < Array.Length; i++)
{
System.Console.Write($"{number} ^ 3 = "); // с помощью $ в {понимается переменная}, формирования строки таким способом называется интерполяцией.
System.Console.WriteLine(Array[i]);
number++;
}
}
int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);

