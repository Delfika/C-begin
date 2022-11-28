// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Введите число для поиска");
int find = int.Parse(Console.ReadLine()!);
var Massive = CreateArray(3,4);
PrintArray(Massive);
int [,] CreateArray (int x,int y)
{ 
var random = new Random ();
int [,] array = new int [x,y];
for (int i=0; i<array.GetLength(0);i++)
{
    for (int j=0;j<array.GetLength(1);j++)
    {
        array[i,j] =  random.Next(20,30);
    }
}
return array;
}
void PrintArray(int [,] array)
{
    for (var i=0; i<array.GetLength(0);i++)
{
    for (var j=0;j<array.GetLength(1);j++)
    {
       
       Console.Write(array[i,j] );
        if (j != array.GetLength(1)-1)
        Console.Write (", ");
    }
    Console.WriteLine();
} 
}
int  Find(int [,] array,int find)
{ int x = 0;
    for (var i=0; i<array.GetLength(0);i++)
{
    for (var j=0;j<array.GetLength(1);j++)
    {
       if (array[i,j] == find) 
     return array[i,j];
    }
} 
 return x;
}
int number = Find (Massive,find);
if (number ==0) Console.WriteLine("Заданного числа нет");
else Console.WriteLine("Заданное число " +number);