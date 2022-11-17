// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateArrayWithRandomNumbers(int numbers = 3, int startInterval=0,int endInterval = 5)
{
    var result = new int [numbers];
    Random random = new ();
    for (int i=0;i<numbers;i++)
    {
        result [i] = random.Next (startInterval,endInterval + 1);
    }
    return result;
}
int Summ (int[] input)
{
    int result=0;
        for (int i=0;i<input.Length;i++)
    {
        if (i%2!=0)  
        result += input[i];
    }
    return result;
}
void Print(int[] input)
{ 
    for (int i=0;i<input.Length;i++)
    {
        Console.Write(input[i]);
        if (i!=input.Length-1)
        Console.Write(", ");
    }
Console.WriteLine();
} 
var array=CreateArrayWithRandomNumbers();
Print(array);
var Summa = Summ(array);
Console.WriteLine(Summa);