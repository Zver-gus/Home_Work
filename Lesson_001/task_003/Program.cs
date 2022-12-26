Console.Write("Введите число для проверки на чётность ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Не чётное");
}