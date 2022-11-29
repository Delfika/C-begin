// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
var Massive1 =CreateArray(2,2);
PrintArray1(Massive1);
Console.WriteLine();
var Massive2 =CreateArray2(2,2);
PrintArray2(Massive2);
Console.WriteLine();
var Massive3 =CreateArray3(Massive1,Massive2,2,2);
PrintArray3(Massive3);

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
void PrintArray1(int [,] input)
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
int [,] CreateArray2 (int rows, int columns)
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
void PrintArray2(int [,] input)
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

int [,] CreateArray3 (int [,] Massive1, int [,]Massive2,int rows,int columns)
{   int [,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
{   for (int j = 0; j < columns; j++)
            {
                array[i, j] = 0;
                for (int n = 0; n < columns; n++)
                {
                    array[i, j] = array[i, j]+(Massive1[i, n] * Massive2[n, j]);
                }
            }
}
    return array;
}
void PrintArray3(int [,] input)
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