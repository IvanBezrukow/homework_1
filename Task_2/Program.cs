Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>a)
{
    max = b;
    if (b>c)
    {
        max = b;
    }
    else 
    max = c;
}
if (c>a)
{
    max = c;
}
Console.Write("max = ");
Console.WriteLine(max);