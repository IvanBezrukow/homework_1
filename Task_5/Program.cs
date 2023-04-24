Console.Write("Введите число = ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 9)
{
    while (num1 > 100)
    {
        num1 = num1 / 10;
    }
    int num2left = num1 % 10;
    Console.WriteLine($"Вторая цифра = {num2left}");
}
else
    Console.WriteLine("Второй цифры нет");