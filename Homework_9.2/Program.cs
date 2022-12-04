int Summ(int m,int n)
{
    if (n==m)
    return n;
    return n + Summ(m,n - 1);
}
Console.WriteLine("Введите значение M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма элементов = {Summ(m,n)}");


