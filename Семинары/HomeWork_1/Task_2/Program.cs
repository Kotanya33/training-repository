int a;
int b;
int c;
int max;

Console.Write("Введите первое число ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
c = Convert.ToInt32(Console.ReadLine());

max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine("max = " + max);
