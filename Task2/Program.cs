// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


System.Console.WriteLine("Введите первое из трех число :");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе из трех число :");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье из трех число :");
int num3 = Convert.ToInt32(Console.ReadLine());
int maxNum = num1;

if (num2 > maxNum && num2 > num3)
{
    maxNum = num2;
}
else if(num3 > maxNum && num3 > num2)
{
    maxNum = num3;
} 
else
{
    maxNum = num1;
}
System.Console.WriteLine($"Наибольшее из трех чилел : {maxNum}");

