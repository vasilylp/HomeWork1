
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

