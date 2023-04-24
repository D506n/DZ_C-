Console.WriteLine("Введите первое число:");
int NumA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int NumB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int NumС = Convert.ToInt32(Console.ReadLine());
int Max = NumA;
if (Max < NumB)
{
    Max = NumB;
}
if (Max < NumС)
{
    Max = NumС;
}
Console.WriteLine($"Максимальное число: {Max}");
Console.WriteLine("Введите любой символ для выхода"); //Добавил для того, чтобы окно консоли не закрывалось сразу как только выдаст результат
Console.ReadLine();