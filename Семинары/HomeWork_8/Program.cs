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

//! Задайте двумерный массив. Напишите программу, 
//! которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] DescendingRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j1 = 0; j1 < array.GetLength(1) - 1; j1++)
            for (int j2 = j1 + 1; j2 < array.GetLength(1); j2++)
                if (array[i, j1] < array[i, j2])
                {
                    int temp = array[i, j1];
                    array[i, j1] = array[i, j2];
                    array[i, j2] = temp;
                }
    return array;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
Console.WriteLine();
myArray = DescendingRows(myArray);
Show2DArray(myArray);


//! Задайте прямоугольный двумерный массив. Напишите программу, 
//! которая будет находить строку с наименьшей суммой элементов.
int MinSumRow(int[,] array)
{
    int minSum = 0;
    int minRow = 1;
    for (int column = 0; column < array.GetLength(1); column++)
        minSum += array[0, column];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i + 1;
        }
    }
    return minRow;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
Console.WriteLine(MinSumRow(myArray) + " строка");


//! Заполните спирально массив 4 на 4.
//! Например, на выходе получается вот такой массив:
//! 1  2  3  4       1  2  3  4  5
//! 12 13 14 5       16 17 18 19 6
//! 11 16 15 6       15 24 25 20 7
//! 10 9  8  7       14 23 22 21 8
//!                  13 12 11 10 9
int[,] Spiral(int min, int[,] array, int i, int j)
{
    int size = array.GetLength(0);

    while (j < size && array[i, j] == 0)
    { array[i, j] = min; min++; j++; }
    i += 1; j -= 1;
    while (i < size && array[i, j] == 0)
    { array[i, j] = min; min++; i++; }
    j -= 1; i -= 1;
    while (j >= 0 && array[i, j] == 0)
    { array[i, j] = min; min++; j--; }
    j += 1; i -= 1;
    while (i > 0 && array[i, j] == 0)
    { array[i, j] = min; min++; i--; }
    if (array[i + 1, j + 1] == 0)
        return Spiral(array[i + 1, j] + 1, array, i + 1, j + 1);
    else return array;
}

Console.Write("Задайте размер квадратной матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
int[,] myArray = new int[n, n];
myArray = Spiral(min, myArray, 0, 0);
Show2DArray(myArray);
