﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= num; i = i + 2)
{
    System.Console.WriteLine(i);
}
