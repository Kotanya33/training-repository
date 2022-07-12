//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int HowManyPositive(int m)
{
    int result = 0;
    double[] array = new double[m];
    for(int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
        if(array[i] > 0) result++;
    }
    Console.WriteLine();
    return result;
}
/*
Console.WriteLine("Сколько чисел хотите ввести?");
int m = Convert.ToInt32(Console.ReadLine());
int positive = HowManyPositive(m);
Console.WriteLine($"Положительных чисел {positive}");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void IintersectionOf2Lines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые не пересекаются");
    else
        if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
        else
        {
            double x = (b2 - b1)/(k1-k2);
            double y = k1 * x + b1;
            Console.WriteLine($"Точка пересечения ({x};{y})");
        }
}

Console.Write("Введите b1 " );
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1 " );
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2 " );
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2 " );
double k2 = Convert.ToDouble(Console.ReadLine());
IintersectionOf2Lines(b1, k1, b2, k2);
