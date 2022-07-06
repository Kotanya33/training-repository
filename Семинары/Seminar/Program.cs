//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int Koord(int x, int y)
{
    int quad = 0;
    if(x !=0 && y !=0)
    {
        if(x>0 && y>0) quad = 1;
        if(x<0 && y>0) quad = 2;
        if(x<0 && y<0) quad = 3;
        if(x>0 && y<0) quad = 4;
    }
    return quad;
}
Console.Write("Введите x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y = ");
int y = Convert.ToInt32(Console.ReadLine());

int quad = Koord(x, y);
Console.WriteLine(quad);
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.
/*
void Quad(int n)
{
    int count = 1;
    while(count <= n)
    {
        int proisv = count*count;
        count++;
        Console.WriteLine(proisv);
    }
}
Console.Write("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());
Quad(n);
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Kolich(int num)
{
    int result = 1;
    int i = 1;
    while(num / i > 10)
    {
        i = i * 10;
        result++;
    }
    return result;
}
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Kolich(n));
*/


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Proisv(int N)
{
    int result = 1;
    for(int i = 1; i <= N; i++)
        result = result * i;
    return result;
}
Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Proisv(n));
*/


// Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Step(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
        result = result * a;
    return result;
}
Console.Write("Введите первое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Step(n, m));
*/
