﻿Console.Write("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= n)
{
    if (i % 2 == 0)
    {
         Console.Write(i);
         Console.Write(", ");
    }
    i++;
}