// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите размер массива");
double min = 0;
double max = 0;
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
array[i] = rand.Next(-100, 100) + rand.NextDouble();
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
        {
            max = array[j];
        }
    if (array[j] < min)
        {
            min = array[j];
        }
}
void Print(double [] Array)
{ 
    for (int i=0;i<Array.Length;i++)
    Console.WriteLine(Array[i]);
} 
Print (array);
double raznica = max - min;
Console.WriteLine("Максимальное значение ="+ max);
Console.WriteLine("Максимальное значение ="+ min);
Console.WriteLine("Разница между максимальным и минимальным элементом массива ="+ raznica);


