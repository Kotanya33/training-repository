/* Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа. */

int Task1()
{
    Console.Write("Введите трехзначное число ");
    int n = Convert.ToInt32(Console.ReadLine());

    int des = n % 100 / 10;
    return des;
}
int k = Task1();
Console.WriteLine("вторая цифра " + k);


/*  Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет. */

void Task2()
{
    Console.Write("Введите число "); // 
    int n = Convert.ToInt32(Console.ReadLine());
    int count = 10;
    int third = 0;

    if(n / 100 > 0)
    {
        while(n / count > 10)
        {
            third = n % count * 10 / count;
            count = count * 10;
        }
        Console.WriteLine("третья цифра " + third);
    }
    else
        Console.WriteLine("третьей цифры нет");  
}
Task2();


/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. */

void Task3()
{
    Console.Write("Введите номер дня недели ");
    int day = Convert.ToInt32(Console.ReadLine());

    if(day < 6 && day > 0)
        Console.WriteLine("Нет, придется поработать...");
    else
        if(day == 6 || day == 7)
            Console.WriteLine("Ура,выходной!");
        else
            Console.WriteLine("напоминаю, в неделе 7 дней!");
}
Task3();