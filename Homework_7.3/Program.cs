// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
var array = CreateArray(3,4);
PrintArray(array);
int [,] CreateArray (int rows, int columns)
{
var random = new Random ();
int [,] array = new int [rows, columns];
for (var i=0; i<rows;i++)
{
    for (var j=0;j<columns;j++)
    {
        array[i,j] = random.Next(-100,101);
    }
}
return array;
}
void PrintArray(int [,] input)
{
    for (var i=0; i<input.GetLength(0);i++)
{
    for (var j=0;j<input.GetLength(1);j++)
    {       
       Console.Write(input[i,j] );
        if (j != input.GetLength(1)-1)
        Console.Write (", ");
    }
    Console.WriteLine();
} 
}
Console.WriteLine(array.GetLength(0));
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
}

