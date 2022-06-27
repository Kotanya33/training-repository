int num1;
int num2;

Console.Write("Введите первое число ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("max = " + num1);
}
else
{
    Console.WriteLine("max = " + num2);
}