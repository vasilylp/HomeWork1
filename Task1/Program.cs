// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число :");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число :");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{
    System.Console.WriteLine($"Большее число : {numA}, Меньшее число : {numB}");
}
else
{
    System.Console.WriteLine($"Большее число : {numB}, Меньшее число : {numA}");
}

