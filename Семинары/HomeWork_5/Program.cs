
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min, max + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] CreateArray(int size)
{
    double[] newArray = new double[size];
    Console.WriteLine("Создайте массив");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        newArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    return newArray;
}

int EvenNumbers(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) result++;
    return result;
}

int SumOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
        sum += array[i];
    return sum;
}

double DifferenceMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
        if(array[i] > max) max = array[i];
        else
            if(array[i] < min) min = array[i];
    double result = max - min;
    return result;
}


//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, 100, 999);
ShowArray(array);
Console.WriteLine("Чётных чисел в массиве " + EvenNumbers(array));


// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Сумма нечетных позиций " + SumOddPositions(array));

//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Задайте размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(size);
Console.WriteLine("Разница максимального и минимального значения " + DifferenceMinMax(array));