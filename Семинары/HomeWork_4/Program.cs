// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumbers(int num)
{
    int sum = 0;
    int i = 10;
    while(num / i > 0)
    {
        sum = sum + (num % i * 10 / i);
        i = i * 10;
    }
    sum = sum + num / (i / 10);
    return sum;
}

Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(x));


// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
void NewArray(int m)
{
    int[] array = new int[m];
    int index = 0;
    while(index < m)
    {
        array[index] = new Random().Next(0, 100);
        Console.WriteLine(array[index]);
        index++;
    }
}
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());
NewArray(m);