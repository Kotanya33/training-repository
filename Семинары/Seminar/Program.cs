//!Напишите программу, которая принимает на вход координаты точки (X и Y), 
//!причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Koord(int x, int y)
{
    int quad = 0;
    if (x != 0 && y != 0)
    {
        if (x > 0 && y > 0) quad = 1;
        if (x < 0 && y > 0) quad = 2;
        if (x < 0 && y < 0) quad = 3;
        if (x > 0 && y < 0) quad = 4;
    }
    return quad;
}

// Console.Write("Введите x = ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y = ");
// int y = Convert.ToInt32(Console.ReadLine());

// int quad = Koord(x, y);
// Console.WriteLine(quad);


//! Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.

void Quad(int n)
{
    int count = 1;
    while (count <= n)
    {
        int proisv = count * count;
        count++;
        Console.WriteLine(proisv);
    }
}

// Console.Write("Введите n ");
// int n = Convert.ToInt32(Console.ReadLine());
// Quad(n);


//!Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Kolich(int num)
{
    int result = 1;
    int i = 1;
    while (num / i > 10)
    {
        i = i * 10;
        result++;
    }
    return result;
}

// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Kolich(n));


//! Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Proisv(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
        result = result * i;
    return result;
}

// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Proisv(n));


//! Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Step(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
        result = result * a;
    return result;
}

// Console.Write("Введите первое число ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Step(n, m));



//!Создание массива случайным образом

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min, max + 1);
    return newArray;
}

//! Создание массива вручную

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Creating array here: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

//! Печать массива

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//! Сумма положительных элементов в массиве
int FindPositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sum += array[i];
    }
    return sum;
}


// Console.Write("Input size of array ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value of elements: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value of elements: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array1 = CreateRandomArray(size, min, max);
// ShowArray(array1);
// int sumOfPositive = FindPositiveSum(array1);
// Console.WriteLine("Sum of positive elements in current array is " + sumOfPositive);



//!Напишите программу замена элементов массива:
//! положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] InversionArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
    return array;
}

// Console.Write("Input size of array ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value of elements: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value of elements: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array1 = CreateRandomArray(size, min, max);
// ShowArray(array1);
// int[] array2 = InversionArray(array1);
// ShowArray(array2);


//! Задайте одномерный массив из 20 случайных чисел. Найдите количество 
//! элементов массива, значения которых лежат в отрезке [10,99].
int Interval(int[] array, int min, int max)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= min && array[i] <= max) result++;
    return result;
}

// Console.Write("Input min : ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max : ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] array1 = CreateRandomArray(20, -100, 100);
// ShowArray(array1);
// int result = Interval(array1, min, max);
// Console.WriteLine(result);


//! Напишите программу, которая перевернёт одномерный массив 
//! (последний элемент будет на первом месте, а первый - на последнем и т.д.)
int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

// int[] myArray = {3, 5, 1, 8, 2, 9, 4};
// myArray = ReverseArray(myArray);
// ShowArray(myArray);


//! Напишите программу, которая будет преобразовывать десятичное число в двоичное.
string ChangeDigitSystem(int num)
{
    string resultNumber = string.Empty;
    while (num > 0)
    {
        resultNumber = num % 2 + resultNumber;
        num /= 2; // num = num / 2;
    }
    return resultNumber;
}
// Console.WriteLine(ChangeDigitSystem(18));

//! Напишите программу, которая принимает на вход три числа и проверяет, 
//! может ли существовать треугольник с сторонами такой длины.
void Tr(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}

// Console.Write("Введите a " );
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите b " );
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите c " );
// int c = Convert.ToInt32(Console.ReadLine());
// Tr(a, b, c);

bool Tr1(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b) return true;
    else return false;
}
// Console.WriteLine(Tr1(1,2,2));


//! Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//! Первые два числа Фибоначчи: 0 и 1.
int[] Fibonacci(int n)
{
    int[] newArray = new int[n];
    Console.WriteLine("Creating array here: ");
    newArray[0] = 0;
    newArray[1] = 1;
    for (int i = 2; i < n; i++)
    {
        newArray[i] = newArray[i - 1] + newArray[i - 2];
    }
    return newArray;
}

// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// ShowArray(Fibonacci(num));


//! Задайте двумерный массив размером m×n, 
//! заполненный случайными целыми числами.
int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newarray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newarray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newarray;
}

//! Печать двумерного массива
void Show2DArray(int[,] array)
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

// int[,] myArray = CreateRandom2DArray(m,n,min,max);
// Show2DArray(myArray);


//! Задайте двумерный массив размера m на n, 
//! каждый элемент в массиве находится по формуле: Aij = i+j. 
//! Выведите полученный массив на экран.
int[,] ArraySumElements(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = i + j;
    return array;
}

// Console.Write("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] newArray = ArraySumElements(m,n);
// Show2DArray(newArray);


//! Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//! и замените эти элементы на их квадраты.
int[,] ArrayQuad(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
                array[i, j] = array[i, j] * array[i, j];
    return array;
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
// ArrayQuad(myArray);
// Show2DArray(myArray);


//! Задайте двумерный массив. Найдите сумму элементов, находящихся на 
//! главной диагонали (с индексами (0,0); (1;1) и т.д.
int findDiagSum(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) == array.GetLength(1))
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, i];

    return sum;
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
// Console.WriteLine("Sum of main diagonal is " + findDiagSum(myArray));

//! ЗАДАЧА 1. Задайте двумерный массив. Напишите программу, 
//! которая поменяет местами первую и последнюю строку массива.
int[,] FirstLastRows(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
    return array;
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
// myArray = FirstLastRows(myArray);
// Show2DArray(myArray);

//! ЗАДАЧА 2. Задайте двумерный массив. Напишите программу, 
//! которая заменяет строки на столбцы. В случае, если это невозможно, 
//! программа должна вывести сообщение для пользователя.
int[,] Reverse2dArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Number of rows and columns is not the same!");
        return array;
    }

    for (int i = 0; i < array.GetLength(0) - 1; i++)
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    return array;
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
// myArray = Reverse2dArray(myArray);
// Show2DArray(myArray);

//! ЗАДАЧА 3. Из двумерного массива целых чисел удалить строку и столбец, 
//! на пересечении которых расположен наименьший элемент.
int[,] Cut2dArray(int[,] array)
{
    int iMin = 0, jMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[iMin, jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    for (int j = 0; j < array.GetLength(1); j++)
        array[iMin, j] = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        array[i, jMin] = 0;
    return array;
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
// myArray = Cut2dArray(myArray);
// Show2DArray(myArray);


//? РЕКУРСИЯ

//! Задайте значение N. Напишите программу, которая выведет 
//! все натуральные числа в промежутке от 1 до N.

void ShowNums(int n)
{
    if (n > 1)
        ShowNums(n - 1);
    Console.Write(n + " ");
}

//ShowNums(5);

//! Напишите программу, которая будет принимать на вход число 
//! и возвращать сумму его цифр.

int SumOfDigits(int n)
{
    if (n >= 10)
    {
        return n % 10 + SumOfDigits(n / 10);
    }
    else return n;
}

//Console.WriteLine(SumOfDigits(12345));

//! Задайте значения M и N. Напишите программу, которая
//! выведет все натуральные числа в промежутке от M до N.
void ShowInterval(int m, int n)
{
    if (n != m)
        ShowInterval(m, n - 1);
    Console.Write(n + " ");
}
//ShowInterval(4,10);

//! Напишите программу, которая на вход принимает два числа
//! A и B, и возводит число А в целую степень B с помощью рекурсии.
int Exponentiation(int a, int b)
{
    if(b > 1)
        return a * Exponentiation(a, b - 1);
    return a;
}
//Console.WriteLine(Exponentiation(2,4));
