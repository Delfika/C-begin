// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-10, 20)) / 10;
        }
    }
}

void PrintArray(double[,] array)
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
// Console.WriteLine("введите количество строк");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[3, 5];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);