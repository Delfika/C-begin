// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

Console.WriteLine("Введите число");
int Number =int.Parse(Console.ReadLine()!);
int Number1 = Number % 10;
int Number2 = (Number/10)%10; /// 123 4
int Number3 = ((Number/10)/10)%10;
int Number4 = (((Number/10)/10)/10)%10;
int Number5 = ((((Number/10)/10)/10)/10)%10;
if (Number5 == Number1 && Number2 == Number4) Console.WriteLine("YES");
else Console.WriteLine("NO");
