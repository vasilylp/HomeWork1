﻿
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


System.Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int rest = num % 2;
if (rest == 0 )
{
    System.Console.WriteLine($"Да, число : {rest} четное");
}
else
{
    System.Console.WriteLine($"Нет, число : {rest} нечетное");
}
