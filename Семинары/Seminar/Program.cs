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


//Создание массива случайным образом
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(min, max + 1);
    return newArray;
}

// Создание массива вручную
int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Creating array here: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

// Печать массива
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Сумма положительных элементов в массиве
int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            sum += array[i];
    }
    return sum;
}

/*
Console.Write("Input size of array ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);
int sumOfPositive = FindPositiveSum(array1);
Console.WriteLine("Sum of positive elements in current array is " + sumOfPositive);
*/


//Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] InversionArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = - array[i];
    return array;    
}
/*
Console.Write("Input size of array ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);
int[] array2 = InversionArray(array1);
ShowArray(array2);
*/

// Задайте одномерный массив из 20 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].
int Interval(int[] array, int min, int max)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= min && array[i] <= max) result++;
    return result;
}

/*
Console.Write("Input min : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(20, -100, 100);
ShowArray(array1);
int result = Interval(array1, min, max);
Console.WriteLine(result);
*/

// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
int[] ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
/*
int[] myArray = {3, 5, 1, 8, 2, 9, 4};
myArray = ReverseArray(myArray);
ShowArray(myArray);
*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
string ChangeDigitSystem(int num)
{
    string resultNumber = string.Empty;
    while(num > 0)
    {
        resultNumber = num % 2 + resultNumber;
        num /= 2; // num = num / 2;
    }
    return resultNumber;
}
// Console.WriteLine(ChangeDigitSystem(18));

// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
void Tr(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}
/*
Console.Write("Введите a " );
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b " );
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите c " );
int c = Convert.ToInt32(Console.ReadLine());
Tr(a, b, c);
*/

bool Tr1(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) return true;
    else return false;
}
// Console.WriteLine(Tr1(1,2,2));


// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
int [] Fibonacci(int n)
{
    
    int[] newArray = new int[n];
    Console.WriteLine("Creating array here: ");
    newArray[0] = 0;
    newArray[1] = 1;
    for(int i = 2; i < n; i++)
    {
        newArray[i] = newArray[i - 1] + newArray[ i - 2];
    }
    return newArray;
}
/*
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
ShowArray(Fibonacci(num));
*/