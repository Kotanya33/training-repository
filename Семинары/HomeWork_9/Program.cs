//! Задайте значение N. Напишите программу, которая 
//! найдет кол-во цифр в числе N рекурсивным методом.
int HowManyDigits(int n)
{
    if (n / 10 > 0)
        return n/n + HowManyDigits(n / 10);
    return n/n;
}
Console.Write("Input N = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(HowManyDigits(x));

//! Задайте значения M и N. Напишите программу, которая 
//! найдёт сумму натуральных элементов в промежутке от M до N.
int SumInretval(int m, int n)
{
    if(n != m)
        return m + SumInretval(m + 1, n);
    return m;
}
Console.Write("Input m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumInretval(m,n));