int num;
int del;

Console.Write("Введите число ");
num = Convert.ToInt32(Console.ReadLine());

del = num / 2;

if(del * 2 == num) 
{
Console.WriteLine("четное");
}
else
{
Console.WriteLine("нечетное");
}