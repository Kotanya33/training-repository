// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом

void Palindrome(int num)
{
    if(num /10000 > 0 && num / 10000 < 10)
        if(num / 10000 == num % 10 && num / 1000 % 10 == num % 100 /10)
            Console.WriteLine("это палиндром");
        else
         Console.WriteLine("это не палиндром");
    else
    Console.WriteLine("это не пятизначное число");
}

Console.Write("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
Palindrome(n);


// Напишите программу, которая принимает на вход число (N) и выдает
// таблицу кубов чисел от 1 до N

void Cube(int N)
{
    int count = 1;
    while(count <= N)
    {
        int cube = count*count*count;
        count++;
        Console.WriteLine(cube);
    }
}
Console.Write("Введите N ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);