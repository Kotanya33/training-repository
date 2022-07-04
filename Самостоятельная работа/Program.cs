/* ЗАДАЧА 1 - Шахматный король ходит по горизонтали, вертикали и диагонали,
но только на 1 клетку. Даны две различные клетки шахматной доски,
определитие, может ли король попасть с первой клетки на вторую
одним ходом. */
/*
void King(int a1, int b1, int a2, int b2)
{
    if((a2 <= a1 +1 && a2 >= a1 - 1) && (b2 <= b1 +1 && b2 >= b1 - 1))
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}
Console.Write("a1 = ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("a2 = ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
King(a1, b1, a2, b2);
*/

/* ЗАДАЧА 2 - На сковородку одновременно можно положить k котлет.
Каждую котлету нужно с каждой стороны обжаривать m минут непрерывно.
За какое наименьшее время удастся поджарить с обеих сторон n котлет.? */
/*
int Cutlet(int k, int m, int n)
{
    int series = n * 2 / k;
    if(n * 2 % k > 0) series++;
    if(series < 2 && n > 0) series = 2;
    int time = m * series;
    return time;
}
Console.Write("k = ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int time = Cutlet(k, m, n);
Console.WriteLine(time);
*/