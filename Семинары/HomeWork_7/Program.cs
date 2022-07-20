//! Задайте двумерный массив разммером m*n, заполненный случайными вещественными числами.

double[,] CreateRandom2dDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newarray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newarray[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue), 2);
    return newarray;
}
void Show2dDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateRandom2dDoubleArray(m,n,min,max);
// Show2dDoubleArray(myArray);

//! Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//! и возвращает значение этого элемента или же указание, что такого элемента нет.

void ElementValue(double[,] array, int i, int j)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
        Console.WriteLine(array[i,j]);
    else
        Console.WriteLine("Такого элемента нет");
}

// Console.Write("Input number of rows: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int y = Convert.ToInt32(Console.ReadLine());
// ElementValue(myArray, x, y);

//! Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newarray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newarray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newarray;
}
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void ArithmeticalMeanOfColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double mean = 0;
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum = (sum + array[i,j]);
        mean = Math.Round(sum / array.GetLength(0),2);
        Console.Write(mean + "; ");
    }
}

// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2DArray(m,n,min,max);
// Show2DArray(myArray);
// Console.WriteLine();
// ArithmeticalMeanOfColumn(myArray);
