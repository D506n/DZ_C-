Console.WriteLine("Введите первое число:");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int NumB = Convert.ToInt32(Console.ReadLine());
if (NumA > NumB)
{
    Console.WriteLine($"{NumA}>{NumB}");
}
else
{
    Console.WriteLine($"{NumB}>{NumA}");
}
Console.WriteLine("Введите любой символ для выхода"); //Добавил для того, чтобы окно консоли не закрывалось сразу как только выдаст результат
Console.ReadLine();