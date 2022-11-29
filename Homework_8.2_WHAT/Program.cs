// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
var array =CreateArray(4,2);
PrintArray(array);
int [,] CreateArray (int rows, int columns)
{
var random = new Random ();
int [,] array = new int [rows, columns];
for (var i=0; i<rows;i++)
{
    for (var j=0;j<columns;j++)
    {
        array[i,j] = random.Next(1,5);
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
int temp = 0;
int min = 0;
Console.WriteLine(array.GetLength(0));

// for (int i = 0; i < array.GetLength(0); i++)
// {   
//     double sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = sum + array[i, j];
//     }
//     if (sum<min)
//     {
//         min = sum;
//         min++;
//     }
//     Console.Write($"{ sum } "); 
    
// }
int indexLine = 0;

    int index = 0, minsum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
    }
   