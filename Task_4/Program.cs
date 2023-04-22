Console.Write("Введите число = ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 1;
if (num > 1)
while (a < num + 1)
        {
        if (a % 2 == 0)
        {
            Console.Write(" --> ");
            Console.WriteLine(a);
            a = a + 1;
        }
        else 
            a = a + 1;
        }
else 
    Console.WriteLine("Введите другое число");