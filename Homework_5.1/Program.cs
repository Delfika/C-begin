// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int [] CreateArrayWithRandomNumbers(int numbers = 10, int startInterval=100,int endInterval = 1000)
{
    var result = new int [numbers];
    Random random = new ();
    for (int i=0;i<numbers;i++)
    {
        result [i] = random.Next (startInterval,endInterval);
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
int KolvoChisel (int[] input)
{
    int result=0;
        for (int i=0;i<input.Length;i++)
    {
        
        if (input[i]%2==0)  // если остаток равен 0
        result += input[i];
    }
    return result;
}
var array=CreateArrayWithRandomNumbers();
Print(array);
var Sum=KolvoChisel(array);
Console.WriteLine(Sum);


// int Number1 = 10;
//  int Number2 = 10;
//  int n = Number1 % Number2;
//  if (n==0)
//  {  
//     Console.WriteLine("кратно");
//   }

// else
// {
//  Console.WriteLine("не кратно" + n);
// }
