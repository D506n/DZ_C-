Console.WriteLine("Введите число:");
int NumA = Convert.ToInt32(Console.ReadLine());
if (NumA % 2 == 0){
    Console.WriteLine($"Число {NumA} - чётное");
}
else{
    Console.WriteLine($"Число {NumA} - нечётное");
}
Console.WriteLine("Введите любой символ для выхода"); //Добавил для того, чтобы окно консоли не закрывалось сразу как только выдаст результат
Console.ReadLine();