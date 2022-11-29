// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
var array =CreateArray(3,4);
PrintArray(array);
ChangeArray(array);
Console.WriteLine();
PrintArrays(array);
int [,] CreateArray (int rows, int columns)
{
var random = new Random ();
int [,] array = new int [rows, columns];
for (var i=0; i<rows;i++)
{
    for (var j=0;j<columns;j++)
    {
        array[i,j] = random.Next(10,21);
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
void ChangeArray (int [,] input)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int a = 0; a < array.GetLength(1) - 1; a++)
        {
            if (array[i, a] < array[i, a + 1])
            {
                int temp = 0;
                temp = array[i, a];
                array[i, a] = array[i, a + 1];
                array[i, a + 1] = temp;
            }
        }
    }
}
}
void PrintArrays(int [,] input)
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