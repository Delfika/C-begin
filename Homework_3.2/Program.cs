//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// Console.WriteLine("Введите точку 1 xA = ");
// int xA= int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите точку 1 yA = ");
// int yA= int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите точку 1 xB = ");
// int xB= int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите точку 1 yB = ");
// int yB= int.Parse(Console.ReadLine()!);

// double temp1=(xA-xB); 
// double t1= Math.Pow(temp1, 2);
// double temp2=(yA-yB);
// double t2= Math.Pow(temp2, 2);
// double sum= t1+t2;
// double d = Math.Sqrt(sum);
// Console.WriteLine("Растояние равно = "+ d );


double distance (int[] dotsA,int[] dotsB)
{
    return Math.Sqrt(Math.Pow(dotsA[0]-dotsB[0], 2) + Math.Pow(dotsA[1]-dotsB[1],2) + Math.Pow(dotsA[2]-dotsB[2],2));
    //     корень от (хА-хБ,возведение в квадрат) + ...
}
int [] dotsA=new int[3]; // объявление пустого массива из трех элементов [0,0,0]
int [] dotsB= new int[3];
Console.WriteLine("Введите точку 1 xA = ");
dotsA[0]= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите точку 1 yA = ");
dotsA[1]= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите точку 1 xB = ");
dotsB[0]= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите точку 1 yB = ");
dotsB[1]= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите точку 1 zA = ");
dotsA[2]= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите точку 1 zB = ");
dotsB[2]= int.Parse(Console.ReadLine()!);
//Console.WriteLine(Math.Round(distance(dotsA,dotsB),3));
            // Math.Round округляет до значений, в нашем случае до 3 знаков
            Console.WriteLine(distance (dotsA, dotsB));
