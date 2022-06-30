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