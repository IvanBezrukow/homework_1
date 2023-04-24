Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b)
{
    max = a;
}
else
    max = b;
Console.Write("max = ");
Console.WriteLine(max);