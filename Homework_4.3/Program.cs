// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.
// void FillArray(int[] collection)
// {
//     int length = collection.Length; 
//     int index=0;
//     Random random = new Random();
//     while (index< length)
//     {
//         collection[index] = random.Next (0,2);
//         index++ ;
//     }
// }
// void PrintArray (int [] col)
// {
//     Console.WriteLine("Массив");
//     int count = col.Length;
//     int position = 0;
//     while (position<count)
//     {
//         Console.WriteLine (col[position]);
//         position++;
//     }
// }
// Console.WriteLine ("Введите число");
// // int [] array = new int [number];
// FillArray (array);
// PrintArray(array);

// Console.WriteLine("Массив 1:\tМассив2:");
// for (int k = 0; k < 3; k++)
//             {
//                 Console.WriteLine(ar1[k] + "\t" + ar2[k]);
//             }
// int [] collection = {1,3,4,5,6,5};
// int a = collection.Length;
// for (int k = 0; k < a; k++)
//             {
//                 Console.WriteLine(collection[k]+"\t");
                
//                     }

// Console.WriteLine(k);
// ArrayName.Length

// int[] ar1=new int[3];
// int[]ar2=new int[3];
 
//  for (int k = 0; k < 3; k++)
//             {
//                 Console.WriteLine(ar1[k]);
//             }
 
//  for (int k = 0; k < 3; k++)
//             {
//                 Console.WriteLine(ar2[k]);
//             }



// НАПИСАТЬ КОД, КОТОРЫЙ ЗАПИСЫВАЕТ 8МИ ЗНАЧНОЕ ЧИСЛО С КЛАВИАТУРЫ И ПРИСВАИВАЕТ КАЖДУЮ ЦИФРУ ЭТОГО ЧИСЛА В ЯЧЕЙКУ ОДНОМЕРНОГО МАССИВА

Console.WriteLine("Введите восьмизначное число");
int number = int.Parse(Console.ReadLine()!);
int number8 = number % 10;
int number7 = (number / 10)%10;
int number6 = ((number / 10)/10)%10;
int number5 = (((number / 10)/10)/10)%10;
int number4 = (((number / 10)/10)/10)/10%10;
int number3 = (((number / 10)/10)/10)/10/10%10;
int number2 = (((number / 10)/10)/10)/10/10/10%10;
int number1 = (((number / 10)/10)/10)/10/10/10/10%10;
int [] Array = new int [8];
Array [7] =  number8 ;
Array [6] =  number7;
Array [5] =  number6;
Array [4] =  number5;
Array [3] =  number4;
Array [2] =  number3;
Array [1] =  number2;
Array [0] =  number1;
// for (int i = 0; i<Array.Length;i++)
// {Console.WriteLine(Array [i]);}
void PrintArray (int [] Array)
{
    Console.WriteLine("Массив");
    for (int i = 0; i<Array.Length;i++)
    {
        Console.WriteLine(Array [i]);
    }
}
PrintArray(Array);